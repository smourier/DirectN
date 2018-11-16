using System;
using System.Collections.Generic;

namespace DirectN
{
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

        public static T GetUnknown<T>(this ComObject<IMFAttributes> obj, Guid key) => GetUnknown<T>(obj, key, typeof(T).GUID);
        public static T GetUnknown<T>(this ComObject<IMFAttributes> obj, Guid key, Guid interfaceId) => GetUnknown<T>(obj?.Object, key, interfaceId);
        public static T GetUnknown<T>(this IMFAttributes obj, Guid key) => GetUnknown<T>(obj, key, typeof(T).GUID);
        public static T GetUnknown<T>(this IMFAttributes obj, Guid key, Guid interfaceId)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUnknown(key, interfaceId, out var value).IsError)
                return default(T);

            return (T)value;
        }

        public static IntPtr GetBlob(this ComObject<IMFAttributes> obj, Guid key) => GetBlob(obj, key, out var size);
        public static IntPtr GetBlob(this ComObject<IMFAttributes> obj, Guid key, out int size) => GetBlob(obj?.Object, key, out size);
        public static IntPtr GetBlob(this IMFAttributes obj, Guid key) => GetBlob(obj, key, out var size);
        public static IntPtr GetBlob(this IMFAttributes obj, Guid key, out int size)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetAllocatedBlob(key, out var ptr, out size).IsError)
                return IntPtr.Zero;

            return ptr;
        }

        public static string GetString(this ComObject<IMFAttributes> obj, Guid key, string defaultValue = null) => GetString(obj?.Object, key, defaultValue);
        public static string GetString(this IMFAttributes obj, Guid key, string defaultValue = null)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetStringLength(key, out var value).IsError)
                return defaultValue;

            var s = new string('\0', value);
            if (obj.GetString(key, s, value, ref value).IsError)
                return defaultValue;

            return s;
        }
    }
}
