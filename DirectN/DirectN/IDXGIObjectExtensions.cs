using System;

namespace DirectN
{
    public static class IDXGIObjectExtensions
    {
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIObject> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIDeviceSubObject> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIAdapter> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIAdapter1> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIAdapter2> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIAdapter3> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIAdapter4> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIDevice> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIDevice1> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIDevice2> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIDevice3> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIDevice4> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIFactory> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIFactory1> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIFactory2> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIFactory3> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIFactory4> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIFactory5> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput1> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput2> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput3> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput4> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput5> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput6> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGISwapChain> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGISwapChain1> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGISwapChain2> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGISwapChain3> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGISwapChain4> obj) => GetParent<T>(obj?.Object);
        public static ComObject<T> GetParent<T>(this IDXGIObject obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.GetParent(typeof(T).GUID, out object parent);
            return new ComObject<T>((T)parent);
        }

        public static ComObject GetParent(this IDXGIObject obj, Guid riid)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.GetParent(riid, out object parent);
            return new ComObject(parent);
        }
    }
}
