using System;
using System.Collections.Generic;

namespace DirectN
{
    public static class IDXGIAdapterExtensions
    {
        public static int GetIndex(this IDXGIAdapter adapter)
        {
            if (adapter == null)
                throw new ArgumentNullException(nameof(adapter));

            using (var fac = DXGIFunctions.CreateDXGIFactory1())
            {
                var desc = adapter.GetDesc();
                int i = 0;
                do
                {
                    if (fac.Object.EnumAdapters((uint)i, out var a).IsError)
#if DEBUG
                        throw new InvalidOperationException();
#else
                        return -1; // wot?
#endif

                    var desca = a.GetDesc();
                    if (desca.AdapterLuid.luid == desc.AdapterLuid.luid)
                        return i;

                    i++;
                }
                while (true);
            }
        }

        public static DXGI_ADAPTER_DESC GetDesc(this IComObject<IDXGIAdapter> adapter) => GetDesc(adapter?.Object);
        //public static DXGI_ADAPTER_DESC GetDesc(this ComObject<IDXGIAdapter1> adapter) => GetDesc(adapter?.Object);
        public static DXGI_ADAPTER_DESC GetDesc(this IDXGIAdapter adapter)
        {
            if (adapter == null)
                throw new ArgumentNullException(nameof(adapter));

            var desc = new DXGI_ADAPTER_DESC();
            adapter.GetDesc(out desc).ThrowOnError();
            return desc;
        }

        public static DXGI_ADAPTER_DESC1 GetDesc1(this IComObject<IDXGIAdapter1> adapter) => GetDesc1(adapter?.Object);
        public static DXGI_ADAPTER_DESC1 GetDesc1(this IDXGIAdapter1 adapter)
        {
            if (adapter == null)
                throw new ArgumentNullException(nameof(adapter));

            var desc = new DXGI_ADAPTER_DESC1();
            adapter.GetDesc1(out desc).ThrowOnError();
            return desc;
        }

        public static IEnumerable<IComObject<T>> EnumOutputs<T>(this IComObject<IDXGIAdapter> factory) where T : IDXGIOutput => EnumOutputs<T>(factory?.Object);
        //public static IEnumerable<IComObject<T>> EnumOutputs<T>(this IComObject<IDXGIAdapter1> factory) where T : IDXGIOutput => EnumOutputs<T>(factory?.Object);
        public static IEnumerable<IComObject<T>> EnumOutputs<T>(this IDXGIAdapter adapter) where T : IDXGIOutput
        {
            if (adapter == null)
                throw new ArgumentNullException(nameof(adapter));

            uint i = 0;
            do
            {
                if (adapter.EnumOutputs(i++, out var output).IsError)
                    yield break;

                yield return new ComObject<T>((T)output);
            }
            while (true);
        }

        public static IEnumerable<IComObject<IDXGIOutput1>> EnumOutputs(this IComObject<IDXGIAdapter> adapter) => EnumOutputs(adapter?.Object);
        //public static IEnumerable<IComObject<IDXGIOutput1>> EnumOutputs(this IComObject<IDXGIAdapter1> adapter) => EnumOutputs(adapter?.Object); 
        public static IEnumerable<IComObject<IDXGIOutput1>> EnumOutputs(this IDXGIAdapter adapter)
        {
            if (adapter == null)
                throw new ArgumentNullException(nameof(adapter));

            uint i = 0;
            do
            {
                if (adapter.EnumOutputs(i++, out var output).IsError)
                    yield break;

                yield return new ComObject<IDXGIOutput1>((IDXGIOutput1)output);
            }
            while (true);
        }
    }
}
