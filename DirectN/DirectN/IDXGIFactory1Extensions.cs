using System;
using System.Collections.Generic;

namespace DirectN
{
    public static class IDXGIFactory1Extensions
    {
        public static IEnumerable<ComObject<IDXGIAdapter1>> EnumAdapters(this ComObject<IDXGIFactory1> factory) => EnumAdapters<IDXGIAdapter1>(factory);
        public static IEnumerable<ComObject<T>> EnumAdapters<T>(this ComObject<IDXGIFactory1> factory) where T : IDXGIAdapter1
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            int i = 0;
            do
            {
                if (factory.Object.EnumAdapters1(i++, out IDXGIAdapter1 adapter).IsError)
                    yield break;

                yield return new ComObject<T>((T)adapter);
            }
            while (true);
        }

        public static IEnumerable<ComObject<IDXGIAdapter1>> EnumAdapters(this ComObject<IDXGIFactory2> factory) => EnumAdapters<IDXGIAdapter1>(factory);
        public static IEnumerable<ComObject<T>> EnumAdapters<T>(this ComObject<IDXGIFactory2> factory) where T : IDXGIAdapter1
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            int i = 0;
            do
            {
                if (factory.Object.EnumAdapters1(i++, out IDXGIAdapter1 adapter).IsError)
                    yield break;

                yield return new ComObject<T>((T)adapter);
            }
            while (true);
        }
    }
}
