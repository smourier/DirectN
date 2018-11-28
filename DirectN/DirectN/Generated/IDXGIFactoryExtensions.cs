using System;
using System.Collections.Generic;

namespace DirectN
{
    public static class IDXGIFactoryExtensions
    {
        public static IEnumerable<ComObject<T>> EnumAdapters<T>(this ComObject<IDXGIFactory> factory) where T : IDXGIAdapter => EnumAdapters<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumAdapters<T>(this ComObject<IDXGIFactory1> factory) where T : IDXGIAdapter => EnumAdapters<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumAdapters<T>(this ComObject<IDXGIFactory2> factory) where T : IDXGIAdapter => EnumAdapters<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumAdapters<T>(this ComObject<IDXGIFactory3> factory) where T : IDXGIAdapter => EnumAdapters<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumAdapters<T>(this ComObject<IDXGIFactory4> factory) where T : IDXGIAdapter => EnumAdapters<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumAdapters<T>(this ComObject<IDXGIFactory5> factory) where T : IDXGIAdapter => EnumAdapters<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumAdapters<T>(this IDXGIFactory factory) where T : IDXGIAdapter
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            int i = 0;
            do
            {
                if (factory.EnumAdapters(i++, out IDXGIAdapter adapter).IsError)
                    yield break;

                yield return new ComObject<T>((T)adapter);
            }
            while (true);
        }
    }
}
