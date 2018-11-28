using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DirectN
{
    // we want to avoid PropVariant stuff
    public static class IMFAttributesExtensions
    {
        public static IEnumerable<KeyValuePair<Guid, MF_ATTRIBUTE_TYPE>> Enumerate(this ComObject<IMFAttributes> obj) => Enumerate(obj?.Object);
        public static IEnumerable<KeyValuePair<Guid, MF_ATTRIBUTE_TYPE>> Enumerate(this IMFAttributes obj)
        {
            if (obj == null)
                yield break;

            for (int i = 0; i < Count(obj); i++)
            {
                obj.GetItemByIndex(i, out Guid guid, null).ThrowOnError();
                obj.GetItemType(guid, out var type).ThrowOnError();
                yield return new KeyValuePair<Guid, MF_ATTRIBUTE_TYPE>(guid, type);
            }
        }

        public static int Count(this ComObject<IMFAttributes> obj) => Count(obj?.Object);
        public static int Count(this IMFAttributes obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.GetCount(out var value).ThrowOnError();
            return value;
        }

        public static T Get<T>(this ComObject<IMFAttributes> obj, Guid key, T defaultValue = default(T), IFormatProvider provider = null) => Get(obj?.Object, key, defaultValue, provider);
        public static T Get<T>(this IMFAttributes obj, Guid key, T defaultValue = default(T), IFormatProvider provider = null)
        {
            if (!TryGet(obj, key, provider, out T value))
                return defaultValue;

            return value;
        }

        public static bool TryGet<T>(this ComObject<IMFAttributes> obj, Guid key, out T value) => TryGet(obj?.Object, key, null, out value);
        public static bool TryGet<T>(this ComObject<IMFAttributes> obj, Guid key, IFormatProvider provider, out T value) => TryGet(obj?.Object, key, provider, out value);
        public static bool TryGet<T>(this IMFAttributes obj, Guid key, out T value) => TryGet(obj, key, null, out value);
        public static bool TryGet<T>(this IMFAttributes obj, Guid key, IFormatProvider provider, out T value)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetItemType(key, out var type).IsError)
            {
                value = default(T);
                return false;
            }

            T item;
            switch (type)
            {
                case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_BLOB:
                    if (typeof(T) == typeof(IntPtr))
                    {
                        value = (T)(object)GetAllocatedBlob(obj, key);
                        return true;
                    }

                    var bytes = GetBlob(obj, key);
                    if (!Conversions.TryChangeType(bytes, provider, out item))
                    {
                        value = default(T);
                        return false;
                    }

                    value = item;
                    return true;

                case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_DOUBLE:
                    var dbl = GetDouble(obj, key);
                    if (!Conversions.TryChangeType(dbl, provider, out item))
                    {
                        value = default(T);
                        return false;
                    }

                    value = item;
                    return true;

                case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_GUID:
                    var guid = GetGuid(obj, key);
                    if (!Conversions.TryChangeType(guid, provider, out item))
                    {
                        value = default(T);
                        return false;
                    }

                    value = item;
                    return true;

                case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_STRING:
                    var s = GetString(obj, key);
                    if (!Conversions.TryChangeType(s, provider, out item))
                    {
                        value = default(T);
                        return false;
                    }

                    value = item;
                    return true;

                case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_UINT32:
                    var ui = GetUInt32(obj, key);
                    if (!Conversions.TryChangeType(ui, provider, out item))
                    {
                        value = default(T);
                        return false;
                    }

                    value = item;
                    return true;

                case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_UINT64:
                    var ul = GetUInt64(obj, key);
                    if (!Conversions.TryChangeType(ul, provider, out item))
                    {
                        value = default(T);
                        return false;
                    }

                    value = item;
                    return true;

                case MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_IUNKNOWN:
                    var comType = ComObject.GetGenericComObjectComType(typeof(T));
                    if (comType == null)
                    {
                        value = (T)GetUnknown(obj, key, typeof(T).GUID);
                        return value != null;
                    }

                    var unk = GetUnknown(obj, key, comType.GUID);
                    if (unk == null)
                    {
                        value = default(T);
                        return false;
                    }

                    value = (T)(object)ComObject.WrapAsGeneric(comType, unk);
                    return true;

                default:
                    throw new NotSupportedException();
            }
        }

        public static Guid GetGuid(this ComObject<IMFAttributes> obj, Guid key) => GetGuid(obj?.Object, key, Guid.Empty);
        public static Guid GetGuid(this ComObject<IMFAttributes> obj, Guid key, Guid defaultValue) => GetGuid(obj?.Object, key, defaultValue);
        public static Guid GetGuid(this IMFAttributes obj, Guid key) => GetGuid(obj, key, Guid.Empty);
        public static Guid GetGuid(this IMFAttributes obj, Guid key, Guid defaultValue)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetGUID(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static double GetDouble(this ComObject<IMFAttributes> obj, Guid key, double defaultValue = 0) => GetDouble(obj?.Object, key, defaultValue);
        public static double GetDouble(this IMFAttributes obj, Guid key, double defaultValue = 0)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetDouble(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static bool GetBoolean(this ComObject<IMFAttributes> obj, Guid key, bool defaultValue = false) => GetBoolean(obj?.Object, key, defaultValue);
        public static bool GetBoolean(this IMFAttributes obj, Guid key, bool defaultValue = false)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUINT32(key, out var value).IsError)
                return defaultValue;

            return value != 0;
        }

        public static int GetInt32(this ComObject<IMFAttributes> obj, Guid key, int defaultValue = 0) => GetInt32(obj?.Object, key, defaultValue);
        public static int GetInt32(this IMFAttributes obj, Guid key, int defaultValue = 0)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUINT32(key, out var value).IsError)
                return defaultValue;

            return (int)value;
        }

        public static uint GetUInt32(this ComObject<IMFAttributes> obj, Guid key, uint defaultValue = 0) => GetUInt32(obj?.Object, key, defaultValue);
        public static uint GetUInt32(this IMFAttributes obj, Guid key, uint defaultValue = 0)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUINT32(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static ulong GetUInt64(this ComObject<IMFAttributes> obj, Guid key, ulong defaultValue = 0) => GetUInt64(obj?.Object, key, defaultValue);
        public static ulong GetUInt64(this IMFAttributes obj, Guid key, ulong defaultValue = 0)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUINT64(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static long GetInt64(this ComObject<IMFAttributes> obj, Guid key, long defaultValue = 0) => GetInt64(obj?.Object, key, defaultValue);
        public static long GetInt64(this IMFAttributes obj, Guid key, long defaultValue = 0)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUINT64(key, out var value).IsError)
                return defaultValue;

            return (long)value;
        }

        public static object GetUnknown(this ComObject<IMFAttributes> obj, Guid key, Guid interfaceId) => GetUnknown(obj?.Object, key, interfaceId);
        public static object GetUnknown(this IMFAttributes obj, Guid key, Guid interfaceId)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUnknown(key, interfaceId, out var value).IsError)
                return null;

            return value;
        }

        public static ComObject<T> GetUnknown<T>(this ComObject<IMFAttributes> obj, Guid key) => GetUnknown<T>(obj, key, typeof(T).GUID);
        public static ComObject<T> GetUnknown<T>(this ComObject<IMFAttributes> obj, Guid key, Guid interfaceId) => GetUnknown<T>(obj?.Object, key, interfaceId);
        public static ComObject<T> GetUnknown<T>(this IMFAttributes obj, Guid key) => GetUnknown<T>(obj, key, typeof(T).GUID);
        public static ComObject<T> GetUnknown<T>(this IMFAttributes obj, Guid key, Guid interfaceId)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUnknown(key, interfaceId, out var value).IsError)
                return null;

            return new ComObject<T>((T)value);
        }

        public static IntPtr GetAllocatedBlob(this ComObject<IMFAttributes> obj, Guid key) => GetAllocatedBlob(obj, key, out var size);
        public static IntPtr GetAllocatedBlob(this ComObject<IMFAttributes> obj, Guid key, out int size) => GetAllocatedBlob(obj?.Object, key, out size);
        public static IntPtr GetAllocatedBlob(this IMFAttributes obj, Guid key) => GetAllocatedBlob(obj, key, out var size);
        public static IntPtr GetAllocatedBlob(this IMFAttributes obj, Guid key, out int size)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetAllocatedBlob(key, out var ptr, out size).IsError)
                return IntPtr.Zero;

            return ptr;
        }

        public static byte[] GetBlob(this ComObject<IMFAttributes> obj, Guid key) => GetBlob(obj, key);
        public static byte[] GetBlob(this IMFAttributes obj, Guid key)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetAllocatedBlob(key, out var ptr, out var size).IsError)
                return null;

            var bytes = new byte[size];
            Marshal.Copy(ptr, bytes, 0, size);
            Marshal.FreeCoTaskMem(ptr);
            return bytes;
        }

        public static string GetString(this ComObject<IMFAttributes> obj, Guid key, string defaultValue = null) => GetString(obj?.Object, key, defaultValue);
        public static string GetString(this IMFAttributes obj, Guid key, string defaultValue = null)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetStringLength(key, out var length).IsError)
                return defaultValue;

            var s = new string('\0', length);
            length++;
            obj.GetString(key, s, length, ref length).ThrowOnError();
            return s;
        }
    }
}
