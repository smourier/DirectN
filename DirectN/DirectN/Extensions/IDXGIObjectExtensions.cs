using System;

namespace DirectN
{
    public static class IDXGIObjectExtensions
    {
        public static void SetDebugObjectName(this IComObject<IDXGIObject> child, string name) => SetDebugObjectName(child?.Object, name);
        public static void SetDebugObjectName(this IDXGIObject child, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(null, nameof(name));

            using (var mem = new ComMemory(name))
            {
                _ = child.SetPrivateData(Constants.WKPDID_D3DDebugObjectNameW, (uint)(name.Length * 2), mem.Pointer).ThrowOnError();
            }
        }

        public static void SetPrivateData(this IComObject<IDXGIObject> obj, Guid guid, uint dataSize, IntPtr data) => SetPrivateData(obj?.Object, guid, dataSize, data);
        public static void SetPrivateData(this IDXGIObject obj, Guid guid, uint dataSize, IntPtr data)
        {
            obj.SetPrivateData(guid, dataSize, data).ThrowOnError();
        }

        public static void SetPrivateDataInterface(this IComObject<IDXGIObject> obj, Guid guid, IntPtr data) => SetPrivateDataInterface(obj?.Object, guid, data);
        public static void SetPrivateDataInterface(this IDXGIObject obj, Guid guid, IntPtr data)
        {
            obj.SetPrivateDataInterface(guid, data).ThrowOnError();
        }

        public static IComObject<T> GetParent<T>(this IDXGIObject obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.GetParent(typeof(T).GUID, out var parent).ThrowOnError();
            return new ComObject<T>((T)parent);
        }
    }
}
