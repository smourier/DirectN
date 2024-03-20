using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace DirectN
{
    // we want to avoid PropVariant stuff
    public static class IMFAttributesExtensions
    {
        public static string Trace(this IComObject<IMFAttributes> input, string separator = null) => Trace(input?.Object, separator);
        public static string Trace(this IMFAttributes input, string separator = null)
        {
            if (input == null)
                return "<null>";

            separator = separator ?? " | ";
            return string.Join(separator, Enumerate(input).Select(kv => kv.Key.ToName() + "=" + TraceValue(input, kv.Key)));
        }

        public static string TraceValue(this IComObject<IMFAttributes> input, Guid key) => TraceValue(input?.Object, key);
        public static string TraceValue(this IMFAttributes input, Guid key)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            var value = GetValue(input, key);
            if (value == null)
                return "<null>";

            if (value is byte[] bytes)
                return Conversions.ToHexa(bytes, 64);

            if (value is Guid guid)
                return guid.ToName();

            if (value is string s)
                return "`" + s + "`";

            return string.Format(CultureInfo.InvariantCulture, "{0}", value);
        }

        public static IEnumerable<IComObject<IMFActivate>> EnumDeviceSources(this IComObject<IMFAttributes> input) => EnumDeviceSources(input?.Object).Select(a => new ComObject<IMFActivate>(a));
        public static IEnumerable<IMFActivate> EnumDeviceSources(this IMFAttributes input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            Functions.MFEnumDeviceSources(input, out var array, out var count).ThrowOnError();
            for (var i = 0; i < count; i++)
            {
                var ptr = Marshal.ReadIntPtr(array, i * IntPtr.Size);
                var activate = (IMFActivate)Marshal.GetObjectForIUnknown(ptr);
                yield return activate;
                Marshal.Release(ptr);
            }

            Marshal.FreeCoTaskMem(array);
        }

        public static IEnumerable<KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>> Enumerate(this IComObject<IMFAttributes> input) => Enumerate(input?.Object);
        public static IEnumerable<KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>> Enumerate(this IMFAttributes input)
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

        public static KeyValuePair<Guid, object>[] ToValues(this IComObject<IMFAttributes> input) => ToValues(input?.Object);
        public static KeyValuePair<Guid, object>[] ToValues(this IMFAttributes input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            return Enumerate(input).Select(kv => new KeyValuePair<Guid, object>(kv.Key, GetValue(input, kv.Key))).ToArray();
        }

        public static int Count(this IComObject<IMFAttributes> input) => Count(input?.Object);
        public static int Count(this IMFAttributes input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            input.GetCount(out var value).ThrowOnError();
            return (int)value;
        }

        public static void DeleteAllItems(this IComObject<IMFAttributes> input) => DeleteAllItems(input?.Object);
        public static void DeleteAllItems(this IMFAttributes input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            input.DeleteAllItems().ThrowOnError();
        }

        public static void DeleteItem(this IComObject<IMFAttributes> input, Guid key) => DeleteItem(input?.Object, key);
        public static void DeleteItem(this IMFAttributes input, Guid key)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            input.DeleteItem(key).ThrowOnError();
        }

        public static void LockStore(this IComObject<IMFAttributes> input) => LockStore(input?.Object);
        public static void LockStore(this IMFAttributes input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            input.LockStore().ThrowOnError();
        }

        public static void UnlockStore(this IComObject<IMFAttributes> input) => UnlockStore(input?.Object);
        public static void UnlockStore(this IMFAttributes input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            input.UnlockStore().ThrowOnError();
        }

        public static void TryGetItemByIndex(this IComObject<IMFAttributes> input, uint index, out Guid key, out object value) => TryGetItemByIndex(input?.Object, index, out key, out value);
        public static bool TryGetItemByIndex(this IMFAttributes input, uint index, out Guid key, out object value)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            HRESULT hr;
            using (var pv = new PropVariant())
            {
                hr = input.GetItemByIndex(index, out key, pv);
                value = pv.Value;
            }

            return hr.IsSuccess;
        }

        public static void Set2UINT32asUINT64(this IComObject<IMFAttributes> input, Guid key, uint high, uint low) => Set2UINT32asUINT64(input?.Object, key, high, low);
        public static void Set2UINT32asUINT64(this IMFAttributes input, Guid key, uint high, uint low)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            MFSetAttribute2UINT32asUINT64(input, key, high, low).ThrowOnError();
        }

        public static void SetSize(this IComObject<IMFAttributes> input, Guid key, uint width, uint height) => SetSize(input?.Object, key, width, height);
        public static void SetSize(this IMFAttributes input, Guid key, uint width, uint height)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            MFSetAttribute2UINT32asUINT64(input, key, width, height).ThrowOnError();
        }

        public static void SetRatio(this IComObject<IMFAttributes> input, Guid key, uint numerator, uint denominator) => SetRatio(input?.Object, key, numerator, denominator);
        public static void SetRatio(this IMFAttributes input, Guid key, uint numerator, uint denominator)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            MFSetAttribute2UINT32asUINT64(input, key, numerator, denominator).ThrowOnError();
        }

        public static bool TryGet2UINT32asUINT64(this IComObject<IMFAttributes> input, Guid key, out uint high, out uint low) => TryGet2UINT32asUINT64(input?.Object, key, out high, out low);
        public static bool TryGet2UINT32asUINT64(this IMFAttributes input, Guid key, out uint high, out uint low)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            return MFGetAttribute2UINT32asUINT64(input, key, out high, out low).IsSuccess;
        }

        public static bool TryGetSize(this IComObject<IMFAttributes> input, Guid key, out uint width, out uint height) => TryGetSize(input?.Object, key, out width, out height);
        public static bool TryGetSize(this IMFAttributes input, Guid key, out uint width, out uint height) => TryGet2UINT32asUINT64(input, key, out width, out height);

        public static bool TryGetRatio(this IComObject<IMFAttributes> input, Guid key, out uint numerator, out uint denominator) => TryGetRatio(input?.Object, key, out numerator, out denominator);
        public static bool TryGetRatio(this IMFAttributes input, Guid key, out uint numerator, out uint denominator) => TryGet2UINT32asUINT64(input, key, out numerator, out denominator);

        public static ulong Pack2UINT32AsUINT64(uint high, uint low) => ((ulong)high << 32) | low;
        public static void Unpack2UINT32AsUINT64(ulong packed, out uint high, out uint low) { high = (uint)(packed >> 32); low = (uint)packed; }
        public static HRESULT MFSetAttribute2UINT32asUINT64(IMFAttributes attributes, Guid key, uint high, uint low) => attributes?.SetUINT64(key, Pack2UINT32AsUINT64(high, low)) ?? HRESULTS.E_INVALIDARG;
        public static HRESULT MFGetAttribute2UINT32asUINT64(IMFAttributes attributes, Guid key, out uint high, out uint low)
        {
            if (attributes == null)
                throw new ArgumentNullException(nameof(attributes));

            var hr = attributes.GetUINT64(key, out var packed);
            if (hr.IsError)
            {
                high = 0;
                low = 0;
                return hr;
            }

            Unpack2UINT32AsUINT64(packed, out high, out low);
            return HRESULTS.S_OK;
        }

        public static void Set(this IComObject<IMFAttributes> input, Guid key, ComObject value) => input?.Object.SetUnknown(key, value?.Object).ThrowOnError();
        public static void Set(this IComObject<IMFAttributes> input, Guid key, string value) => input?.Object.SetString(key, value).ThrowOnError();
        public static void Set(this IComObject<IMFAttributes> input, Guid key, double value) => input?.Object.SetDouble(key, value).ThrowOnError();
        public static void Set(this IComObject<IMFAttributes> input, Guid key, Guid value) => input?.Object.SetGUID(key, value).ThrowOnError();
        public static void Set(this IComObject<IMFAttributes> input, Guid key, long value) => input?.Object.SetUINT64(key, (ulong)value).ThrowOnError();
        public static void Set(this IComObject<IMFAttributes> input, Guid key, ulong value) => input?.Object.SetUINT64(key, value).ThrowOnError();
        public static void Set(this IComObject<IMFAttributes> input, Guid key, int value) => input?.Object.SetUINT32(key, (uint)value).ThrowOnError();
        public static void Set(this IComObject<IMFAttributes> input, Guid key, uint value) => input?.Object.SetUINT32(key, value).ThrowOnError();
        public static void Set(this IComObject<IMFAttributes> input, Guid key, bool value) => input?.Object.SetUINT32(key, (uint)(value ? 1 : 0)).ThrowOnError();
        public static void Set(this IComObject<IMFAttributes> input, Guid key, Enum value) => input?.Object.SetUINT32(key, (uint)Convert.ChangeType(value, typeof(uint), CultureInfo.InvariantCulture)).ThrowOnError();

        public static T Get<T>(this IComObject<IMFAttributes> input, Guid key, T defaultValue = default, IFormatProvider provider = null) => Get(input?.Object, key, defaultValue, provider);
        public static T Get<T>(this IMFAttributes input, Guid key, T defaultValue = default, IFormatProvider provider = null)
        {
            if (!TryGet(input, key, provider, out T value))
                return defaultValue;

            return value;
        }

        public static bool TryGet<T>(this IComObject<IMFAttributes> input, Guid key, out T value) => TryGet(input?.Object, key, null, out value);
        public static bool TryGet<T>(this IComObject<IMFAttributes> input, Guid key, IFormatProvider provider, out T value) => TryGet(input?.Object, key, provider, out value);
        public static bool TryGet<T>(this IMFAttributes input, Guid key, out T value) => TryGet(input, key, null, out value);
        public static bool TryGet<T>(this IMFAttributes input, Guid key, IFormatProvider provider, out T value)
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

        public static object GetValue(this IComObject<IMFAttributes> input, Guid key) => GetValue(input?.Object, key);
        public static object GetValue(this IMFAttributes input, Guid key)
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

        public static Guid GetGuid(this IComObject<IMFAttributes> input, Guid key) => GetGuid(input?.Object, key, Guid.Empty);
        public static Guid GetGuid(this IComObject<IMFAttributes> input, Guid key, Guid defaultValue) => GetGuid(input?.Object, key, defaultValue);
        public static Guid GetGuid(this IMFAttributes input, Guid key) => GetGuid(input, key, Guid.Empty);
        public static Guid GetGuid(this IMFAttributes input, Guid key, Guid defaultValue)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetGUID(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static double GetDouble(this IComObject<IMFAttributes> input, Guid key, double defaultValue = 0) => GetDouble(input?.Object, key, defaultValue);
        public static double GetDouble(this IMFAttributes input, Guid key, double defaultValue = 0)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetDouble(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static bool GetBoolean(this IComObject<IMFAttributes> input, Guid key, bool defaultValue = false) => GetBoolean(input?.Object, key, defaultValue);
        public static bool GetBoolean(this IMFAttributes input, Guid key, bool defaultValue = false)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUINT32(key, out var value).IsError)
                return defaultValue;

            return value != 0;
        }

        public static int GetInt32(this IComObject<IMFAttributes> input, Guid key, int defaultValue = 0) => GetInt32(input?.Object, key, defaultValue);
        public static int GetInt32(this IMFAttributes input, Guid key, int defaultValue = 0)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUINT32(key, out var value).IsError)
                return defaultValue;

            return (int)value;
        }

        public static uint GetUInt32(this IComObject<IMFAttributes> input, Guid key, uint defaultValue = 0) => GetUInt32(input?.Object, key, defaultValue);
        public static uint GetUInt32(this IMFAttributes input, Guid key, uint defaultValue = 0)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUINT32(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static ulong GetUInt64(this IComObject<IMFAttributes> input, Guid key, ulong defaultValue = 0) => GetUInt64(input?.Object, key, defaultValue);
        public static ulong GetUInt64(this IMFAttributes input, Guid key, ulong defaultValue = 0)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUINT64(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static long GetInt64(this IComObject<IMFAttributes> input, Guid key, long defaultValue = 0) => GetInt64(input?.Object, key, defaultValue);
        public static long GetInt64(this IMFAttributes input, Guid key, long defaultValue = 0)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUINT64(key, out var value).IsError)
                return defaultValue;

            return (long)value;
        }

        public static object GetUnknown(this IComObject<IMFAttributes> input, Guid key, Guid interfaceId) => GetUnknown(input?.Object, key, interfaceId);
        public static object GetUnknown(this IMFAttributes input, Guid key, Guid interfaceId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUnknown(key, interfaceId, out var value).IsError)
                return null;

            return value;
        }

        public static IComObject<T> GetUnknown<T>(this IComObject<IMFAttributes> input, Guid key) => GetUnknown<T>(input, key, typeof(T).GUID);
        public static IComObject<T> GetUnknown<T>(this IComObject<IMFAttributes> input, Guid key, Guid interfaceId) => GetUnknown<T>(input?.Object, key, interfaceId);
        public static IComObject<T> GetUnknown<T>(this IMFAttributes input, Guid key) => GetUnknown<T>(input, key, typeof(T).GUID);
        public static IComObject<T> GetUnknown<T>(this IMFAttributes input, Guid key, Guid interfaceId)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetUnknown(key, interfaceId, out var value).IsError)
                return null;

            return new ComObject<T>((T)value);
        }

        public static byte[] GetBlob(this IComObject<IMFAttributes> input, Guid key) => GetBlob(input, key);
        public static byte[] GetBlob(this IMFAttributes input, Guid key)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetBlobSize(key, out var size).IsError || size == 0)
                return null;

            var bytes = new byte[(int)size];
            input.GetBlob(key, bytes, (int)size, IntPtr.Zero).ThrowOnError();
            return bytes;
        }

        public static string GetString(this IComObject<IMFAttributes> input, Guid key, string defaultValue = null) => GetString(input?.Object, key, defaultValue);
        public static string GetString(this IMFAttributes input, Guid key, string defaultValue = null)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetStringLength(key, out var length).IsError)
                return defaultValue;

            var s = new string('\0', (int)length);
            length++;
            input.GetString(key, s, length, IntPtr.Zero).ThrowOnError();
            return s;
        }
    }
}
