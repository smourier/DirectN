using System;
using System.Collections.Generic;

namespace DirectN
{
    public static class IDXGIAdapterExtensions
    {
        public static DXGI_ADAPTER_DESC GetDesc(this ComObject<IDXGIAdapter> adapter) => GetDesc(adapter?.Object);
        public static DXGI_ADAPTER_DESC GetDesc(this ComObject<IDXGIAdapter1> adapter) => GetDesc(adapter?.Object);
        public static DXGI_ADAPTER_DESC GetDesc(this ComObject<IDXGIAdapter2> adapter) => GetDesc(adapter?.Object);
        public static DXGI_ADAPTER_DESC GetDesc(this ComObject<IDXGIAdapter3> adapter) => GetDesc(adapter?.Object);
        public static DXGI_ADAPTER_DESC GetDesc(this ComObject<IDXGIAdapter4> adapter) => GetDesc(adapter?.Object);
        public static DXGI_ADAPTER_DESC GetDesc(this IDXGIAdapter adapter)
        {
            if (adapter == null)
                throw new ArgumentNullException(nameof(adapter));

            var desc = new DXGI_ADAPTER_DESC();
            adapter.GetDesc(out desc).ThrowOnError();
            return desc;
        }

        public static DXGI_ADAPTER_DESC1 GetDesc1(this ComObject<IDXGIAdapter1> adapter) => GetDesc1(adapter?.Object);
        public static DXGI_ADAPTER_DESC1 GetDesc1(this ComObject<IDXGIAdapter2> adapter) => GetDesc1(adapter?.Object);
        public static DXGI_ADAPTER_DESC1 GetDesc1(this ComObject<IDXGIAdapter3> adapter) => GetDesc1(adapter?.Object);
        public static DXGI_ADAPTER_DESC1 GetDesc1(this ComObject<IDXGIAdapter4> adapter) => GetDesc1(adapter?.Object);
        public static DXGI_ADAPTER_DESC1 GetDesc1(this IDXGIAdapter1 adapter)
        {
            if (adapter == null)
                throw new ArgumentNullException(nameof(adapter));

            var desc = new DXGI_ADAPTER_DESC1();
            adapter.GetDesc1(out desc).ThrowOnError();
            return desc;
        }

        public static DXGI_ADAPTER_DESC2 GetDesc2(this ComObject<IDXGIAdapter2> adapter) => GetDesc2(adapter?.Object);
        public static DXGI_ADAPTER_DESC2 GetDesc2(this ComObject<IDXGIAdapter3> adapter) => GetDesc2(adapter?.Object);
        public static DXGI_ADAPTER_DESC2 GetDesc2(this ComObject<IDXGIAdapter4> adapter) => GetDesc2(adapter?.Object);
        public static DXGI_ADAPTER_DESC2 GetDesc2(this IDXGIAdapter2 adapter)
        {
            if (adapter == null)
                throw new ArgumentNullException(nameof(adapter));

            var desc = new DXGI_ADAPTER_DESC2();
            adapter.GetDesc2(out desc).ThrowOnError();
            return desc;
        }

        public static DXGI_ADAPTER_DESC3 GetDesc3(this ComObject<IDXGIAdapter4> adapter) => GetDesc3(adapter?.Object);
        public static DXGI_ADAPTER_DESC3 GetDesc3(this IDXGIAdapter4 adapter)
        {
            if (adapter == null)
                throw new ArgumentNullException(nameof(adapter));

            var desc = new DXGI_ADAPTER_DESC3();
            adapter.GetDesc3(out desc).ThrowOnError();
            return desc;
        }

        public static IEnumerable<ComObject<T>> EnumOutputs<T>(this ComObject<IDXGIAdapter> factory) where T : IDXGIOutput => EnumOutputs<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumOutputs<T>(this ComObject<IDXGIAdapter1> factory) where T : IDXGIOutput => EnumOutputs<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumOutputs<T>(this ComObject<IDXGIAdapter2> factory) where T : IDXGIOutput => EnumOutputs<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumOutputs<T>(this ComObject<IDXGIAdapter3> factory) where T : IDXGIOutput => EnumOutputs<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumOutputs<T>(this ComObject<IDXGIAdapter4> factory) where T : IDXGIOutput => EnumOutputs<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumOutputs<T>(this IDXGIAdapter adapter) where T : IDXGIOutput
        {
            if (adapter == null)
                throw new ArgumentNullException(nameof(adapter));

            int i = 0;
            do
            {
                if (adapter.EnumOutputs(i++, out IDXGIOutput output).IsError)
                    yield break;

                yield return new ComObject<T>((T)output);
            }
            while (true);
        }
    }
}
