using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DirectN
{
    // we want to avoid PropVariant stuff
    // TODO: now we have covariance, check with IMFAttributesExtensions
    public static class IMFMediaTypeExtensions
    {
        public static IEnumerable<KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>> Enumerate(this IComObject<IMFMediaType> input) => Enumerate(input?.Object);
        public static IEnumerable<KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>> Enumerate(this IMFMediaType input)
        {
            if (input == null)
                yield break;

            for (var i = 0; i < Count(input); i++)
            {
                input.GetItemByIndex((uint)i, out Guid guid, null).ThrowOnError();
                input.GetItemType(guid, out var type).ThrowOnError();
                yield return new KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>(guid, type);
            }
        }

        public static KeyValuePair<Guid, object>[] ToValues(this IComObject<IMFMediaType> input) => ToValues(input?.Object);
        public static KeyValuePair<Guid, object>[] ToValues(this IMFMediaType input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            return Enumerate(input).Select(kv => new KeyValuePair<Guid, object>(kv.Key, GetValue(input, kv.Key))).ToArray();
        }

        public static int Count(this IComObject<IMFMediaType> input) => Count(input?.Object);
        public static int Count(this IMFMediaType input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            input.GetCount(out var value).ThrowOnError();
            return (int)value;
        }

        public static void Set(this IComObject<IMFMediaType> input, Guid key, ComObject value) => input?.Object.SetUnknown(key, value?.Object).ThrowOnError();
        public static void Set(this IComObject<IMFMediaType> input, Guid key, string value) => input?.Object.SetString(key, value).ThrowOnError();
        public static void Set(this IComObject<IMFMediaType> input, Guid key, double value) => input?.Object.SetDouble(key, value).ThrowOnError();
        public static void Set(this IComObject<IMFMediaType> input, Guid key, Guid value) => input?.Object.SetGUID(key, value).ThrowOnError();
        public static void Set(this IComObject<IMFMediaType> input, Guid key, long value) => input?.Object.SetUINT64(key, (ulong)value).ThrowOnError();
        public static void Set(this IComObject<IMFMediaType> input, Guid key, ulong value) => input?.Object.SetUINT64(key, value).ThrowOnError();
        public static void Set(this IComObject<IMFMediaType> input, Guid key, int value) => input?.Object.SetUINT32(key, (uint)value).ThrowOnError();
        public static void Set(this IComObject<IMFMediaType> input, Guid key, uint value) => input?.Object.SetUINT32(key, value).ThrowOnError();
        public static void Set(this IComObject<IMFMediaType> input, Guid key, bool value) => input?.Object.SetUINT32(key, (uint)(value ? 1 : 0)).ThrowOnError();
        public static void Set(this IComObject<IMFMediaType> input, Guid key, Enum value) => input?.Object.SetUINT32(key, (uint)Convert.ChangeType(value, typeof(uint), CultureInfo.InvariantCulture)).ThrowOnError();

        public static T Get<T>(this IComObject<IMFMediaType> input, Guid key, T defaultValue = default, IFormatProvider provider = null) => Get(input?.Object, key, defaultValue, provider);
        public static T Get<T>(this IMFMediaType input, Guid key, T defaultValue = default, IFormatProvider provider = null)
        {
            if (!TryGet(input, key, provider, out T value))
                return defaultValue;

            return value;
        }

        public static bool TryGet<T>(this IComObject<IMFMediaType> input, Guid key, out T value) => TryGet(input?.Object, key, null, out value);
        public static bool TryGet<T>(this IComObject<IMFMediaType> input, Guid key, IFormatProvider provider, out T value) => TryGet(input?.Object, key, provider, out value);
        public static bool TryGet<T>(this IMFMediaType input, Guid key, out T value) => TryGet(input, key, null, out value);
        public static bool TryGet<T>(this IMFMediaType input, Guid key, IFormatProvider provider, out T value)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetItemType(key, out var type).IsError)
            {
                value = default;
                return false;
            }

            T item;
            switch (type)
            {
                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_BLOB:
                    if (typeof(T) == typeof(byte[]))
                    {
                        value = (T)(object)GetBlob(input, key);
                        return true;
                    }

                    var bytes = GetBlob(input, key);
                    if (!Conversions.TryChangeType(bytes, provider, out item))
                    {
                        value = default;
                        return false;
                    }

                    value = item;
                    return true;

                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_DOUBLE:
                    var dbl = GetDouble(input, key);
                    if (!Conversions.TryChangeType(dbl, provider, out item))
                    {
                        value = default;
                        return false;
                    }

                    value = item;
                    return true;

                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_GUID:
                    var guid = GetGuid(input, key);
                    if (!Conversions.TryChangeType(guid, provider, out item))
                    {
                        value = default;
                        return false;
                    }

                    value = item;
                    return true;

                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_STRING:
                    var s = GetString(input, key);
                    if (!Conversions.TryChangeType(s, provider, out item))
                    {
                        value = default;
                        return false;
                    }

                    value = item;
                    return true;

                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_UINT32:
                    var ui = GetUInt32(input, key);
                    if (!Conversions.TryChangeType(ui, provider, out item))
                    {
                        value = default;
                        return false;
                    }

                    value = item;
                    return true;

                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_UINT64:
                    var ul = GetUInt64(input, key);
                    if (!Conversions.TryChangeType(ul, provider, out item))
                    {
                        value = default;
                        return false;
                    }

                    value = item;
                    return true;

                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_IUNKNOWN:
                    var comType = ComObject.GetGenericComObjectComType(typeof(T));
                    if (comType == null)
                    {
                        value = (T)GetUnknown(input, key, typeof(T).GUID);
                        return value != null;
                    }

                    var unk = GetUnknown(input, key, comType.GUID);
                    if (unk == null)
                    {
                        value = default;
                        return false;
                    }

                    value = (T)(object)ComObject.WrapAsGeneric(comType, unk);
                    return true;

                default:
                    throw new NotSupportedException();
            }
        }

        public static object GetValue(this IComObject<IMFMediaType> input, Guid key) => GetValue(input?.Object, key);
        public static object GetValue(this IMFMediaType input, Guid key)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            using (var pv = new PropVariant())
            {
                if (input.GetItem(key, pv).IsError)
                    return null;

                return pv.Value;
            }
        }

        public static Guid GetGuid(this IComObject<IMFMediaType> input, Guid key) => GetGuid(input?.Object, key, Guid.Empty);
        public static Guid GetGuid(this IComObject<IMFMediaType> input, Guid key, Guid defaultValue) => GetGuid(input?.Object, key, defaultValue);
        public static Guid GetGuid(this IMFMediaType input, Guid key) => GetGuid(input, key, Guid.Empty);
        public static Guid GetGuid(this IMFMediaType input, Guid key, Guid defaultValue)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetGUID(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static double GetDouble(this IComObject<IMFMediaType> input, Guid key, double defaultValue = 0) => GetDouble(input?.Object, key, defaultValue);
        public static double GetDouble(this IMFMediaType input, Guid key, double defaultValue = 0)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetDouble(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static bool GetBoolean(this IComObject<IMFMediaType> input, Guid key, bool defaultValue = false) => GetBoolean(input?.Object, key, defaultValue);
        public static bool GetBoolean(this IMFMediaType input, Guid key, bool defaultValue = false)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUINT32(key, out var value).IsError)
                return defaultValue;

            return value != 0;
        }

        public static int GetInt32(this IComObject<IMFMediaType> input, Guid key, int defaultValue = 0) => GetInt32(input?.Object, key, defaultValue);
        public static int GetInt32(this IMFMediaType input, Guid key, int defaultValue = 0)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUINT32(key, out var value).IsError)
                return defaultValue;

            return (int)value;
        }

        public static uint GetUInt32(this IComObject<IMFMediaType> input, Guid key, uint defaultValue = 0) => GetUInt32(input?.Object, key, defaultValue);
        public static uint GetUInt32(this IMFMediaType input, Guid key, uint defaultValue = 0)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUINT32(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static ulong GetUInt64(this IComObject<IMFMediaType> input, Guid key, ulong defaultValue = 0) => GetUInt64(input?.Object, key, defaultValue);
        public static ulong GetUInt64(this IMFMediaType input, Guid key, ulong defaultValue = 0)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUINT64(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static long GetInt64(this IComObject<IMFMediaType> input, Guid key, long defaultValue = 0) => GetInt64(input?.Object, key, defaultValue);
        public static long GetInt64(this IMFMediaType input, Guid key, long defaultValue = 0)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUINT64(key, out var value).IsError)
                return defaultValue;

            return (long)value;
        }

        public static object GetUnknown(this IComObject<IMFMediaType> input, Guid key, Guid interfaceId) => GetUnknown(input?.Object, key, interfaceId);
        public static object GetUnknown(this IMFMediaType input, Guid key, Guid interfaceId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUnknown(key, interfaceId, out var value).IsError)
                return null;

            return value;
        }

        public static IComObject<T> GetUnknown<T>(this IComObject<IMFMediaType> input, Guid key) => GetUnknown<T>(input, key, typeof(T).GUID);
        public static IComObject<T> GetUnknown<T>(this IComObject<IMFMediaType> input, Guid key, Guid interfaceId) => GetUnknown<T>(input?.Object, key, interfaceId);
        public static IComObject<T> GetUnknown<T>(this IMFMediaType input, Guid key) => GetUnknown<T>(input, key, typeof(T).GUID);
        public static IComObject<T> GetUnknown<T>(this IMFMediaType input, Guid key, Guid interfaceId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUnknown(key, interfaceId, out var value).IsError)
                return null;

            return new ComObject<T>((T)value);
        }

        public static byte[] GetBlob(this IComObject<IMFMediaType> input, Guid key) => GetBlob(input, key);
        public static byte[] GetBlob(this IMFMediaType input, Guid key)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetBlobSize(key, out var size).IsError || size == 0)
                return null;

            var bytes = new byte[(int)size];
            input.GetBlob(key, bytes, (int)size, IntPtr.Zero).ThrowOnError();
            return bytes;
        }

        public static string GetString(this IComObject<IMFMediaType> input, Guid key, string defaultValue = null) => GetString(input?.Object, key, defaultValue);
        public static string GetString(this IMFMediaType input, Guid key, string defaultValue = null)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetStringLength(key, out var length).IsError)
                return defaultValue;

            var s = new string('\0', (int)length);
            input.GetString(key, s, length, IntPtr.Zero).ThrowOnError();
            return s;
        }
    }
}
