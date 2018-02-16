using System;

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
    }
}
