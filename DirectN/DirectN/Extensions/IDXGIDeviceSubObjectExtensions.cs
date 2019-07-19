using System;

namespace DirectN
{
    public static class IDXGIDeviceSubObjectExtensions
    {
        public static T GetDevice<T>(this ComObject<IDXGISwapChain> obj) => GetDevice<T>(obj?.Object);
        public static T GetDevice<T>(this ComObject<IDXGISwapChain1> obj) => GetDevice<T>(obj?.Object);
        public static T GetDevice<T>(this ComObject<IDXGISwapChain2> obj) => GetDevice<T>(obj?.Object);
        public static T GetDevice<T>(this ComObject<IDXGISwapChain3> obj) => GetDevice<T>(obj?.Object);
        public static T GetDevice<T>(this ComObject<IDXGISwapChain4> obj) => GetDevice<T>(obj?.Object);
        public static T GetDevice<T>(this ComObject<IDXGIResource> obj) => GetDevice<T>(obj?.Object);
        public static T GetDevice<T>(this ComObject<IDXGIResource1> obj) => GetDevice<T>(obj?.Object);
        public static T GetDevice<T>(this ComObject<IDXGIDeviceSubObject> obj) => GetDevice<T>(obj?.Object);
        public static T GetDevice<T>(this IDXGIDeviceSubObject obj) => (T)GetDevice(obj, typeof(T).GUID);
        public static object GetDevice(this IDXGIDeviceSubObject obj, Guid riid)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.GetDevice(riid, out object parent).ThrowOnError();
            return parent;
        }
    }
}
