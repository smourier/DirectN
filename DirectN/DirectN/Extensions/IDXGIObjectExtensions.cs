using System;

namespace DirectN
{
    public static class IDXGIObjectExtensions
    {
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIObject> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIDeviceSubObject> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIAdapter> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIAdapter1> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIAdapter2> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIAdapter3> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIAdapter4> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIDevice> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIDevice1> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIDevice2> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIDevice3> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIDevice4> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIFactory> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIFactory1> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIFactory2> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIFactory3> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIFactory4> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIFactory5> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput1> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput2> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput3> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput4> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput5> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGIOutput6> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGISwapChain> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGISwapChain1> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGISwapChain2> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGISwapChain3> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this ComObject<IDXGISwapChain4> input) => GetParent<T>(input?.Object);
        public static ComObject<T> GetParent<T>(this IDXGIObject input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            input.GetParent(typeof(T).GUID, out var parent).ThrowOnError();
            return new ComObject<T>((T)parent);
        }

        public static ComObject GetParent(this IDXGIObject input, Guid riid)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            input.GetParent(riid, out var parent).ThrowOnError();
            return new ComObject(parent);
        }
    }
}
