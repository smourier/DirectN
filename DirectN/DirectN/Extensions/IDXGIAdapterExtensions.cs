using System;
using System.Collections.Generic;

namespace DirectN
{
    public static class IDXGIAdapterExtensions
    {
        public static DXGI_ADAPTER_DESC GetDesc(this ComObject<IDXGIAdapter> adapter) => GetDesc(adapter?.Object);
        public static DXGI_ADAPTER_DESC GetDesc(this ComObject<IDXGIAdapter1> adapter) => GetDesc(adapter?.Object);
        public static DXGI_ADAPTER_DESC GetDesc(this IDXGIAdapter adapter)
        {
            if (adapter == null)
                throw new ArgumentNullException(nameof(adapter));

            adapter.GetDesc(out var desc).ThrowOnError();
            return desc;
        }

        public static DXGI_ADAPTER_DESC1 GetDesc1(this ComObject<IDXGIAdapter1> adapter) => GetDesc1(adapter?.Object);
        public static DXGI_ADAPTER_DESC1 GetDesc1(this IDXGIAdapter1 adapter)
        {
            if (adapter == null)
                throw new ArgumentNullException(nameof(adapter));

            adapter.GetDesc1(out var desc).ThrowOnError();
            return desc;
        }

        public static IEnumerable<ComObject<T>> EnumOutputs<T>(this ComObject<IDXGIAdapter> factory) where T : IDXGIOutput => EnumOutputs<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumOutputs<T>(this ComObject<IDXGIAdapter1> factory) where T : IDXGIOutput => EnumOutputs<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumOutputs<T>(this IDXGIAdapter adapter) where T : IDXGIOutput
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

        public static IEnumerable<ComObject<IDXGIOutput1>> EnumOutputs(this ComObject<IDXGIAdapter> adapter) => EnumOutputs(adapter?.Object);
        public static IEnumerable<ComObject<IDXGIOutput1>> EnumOutputs(this ComObject<IDXGIAdapter1> adapter) => EnumOutputs(adapter?.Object); 
        public static IEnumerable<ComObject<IDXGIOutput1>> EnumOutputs(this IDXGIAdapter adapter)
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
