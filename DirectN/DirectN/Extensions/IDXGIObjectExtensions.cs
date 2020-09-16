using System;

namespace DirectN
{
    public static class IDXGIObjectExtensions
    {
        public static IComObject<IDXGIFactory2> GetFactory2(this IComObject<IDXGIAdapter1> surface) => GetParent<IDXGIFactory2>(surface?.Object);
        public static IComObject<IDXGIFactory1> GetFactory1(this IComObject<IDXGIAdapter1> surface) => GetParent<IDXGIFactory1>(surface?.Object);
        public static IComObject<IDXGIFactory> GetFactory(this IComObject<IDXGIAdapter1> surface) => GetParent<IDXGIFactory>(surface?.Object);
        public static IComObject<T> GetParent<T>(this IComObject<IDXGIAdapter1> surface) => GetParent<T>(surface?.Object);
        public static IComObject<T> GetParent<T>(this IDXGIObject obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.GetParent(typeof(T).GUID, out var parent).ThrowOnError();
            return new ComObject<T>((T)parent);
        }
    }
}
