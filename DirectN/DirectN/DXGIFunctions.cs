using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class DXGIFunctions
    {
        private static readonly Lazy<bool> _debugLayerAvailable = new Lazy<bool>(GetDebugLayerAvailable, true);
        public static bool IsDebugLayerAvailable => _debugLayerAvailable.Value;

        private static bool GetDebugLayerAvailable()
        {
            try
            {
                DXGIGetDebugInterface(typeof(IDXGIDebug).GUID, out var debug);
                Marshal.ReleaseComObject(debug);
                return true;
            }
            catch (DllNotFoundException)
            {
                return false;
            }
        }

        public static void DXGIReportLiveObjects() => DXGIReportLiveObjects(DXGIConstants.DXGI_DEBUG_ALL, DXGI_DEBUG_RLO_FLAGS.DXGI_DEBUG_RLO_ALL);
        public static void DXGIReportLiveObjects(Guid apiid) => DXGIReportLiveObjects(apiid, DXGI_DEBUG_RLO_FLAGS.DXGI_DEBUG_RLO_ALL);
        public static void DXGIReportLiveObjects(Guid apiid, DXGI_DEBUG_RLO_FLAGS flags)
        {
            if (!IsDebugLayerAvailable)
                return;

            DXGIGetDebugInterface(typeof(IDXGIDebug).GUID, out var debug);
            if (debug == null || !(debug is IDXGIDebug dbg))
                return;

            dbg.ReportLiveObjects(apiid, flags);
            Marshal.ReleaseComObject(debug);
        }

        [DllImport("dxgi")]
        public static extern HRESULT DXGIDeclareAdapterRemovalSupport();

        [DllImport("dxgi")]
        public static extern HRESULT CreateDXGIFactory([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);

        [DllImport("dxgi")]
        public static extern HRESULT CreateDXGIFactory1([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);

        [DllImport("dxgi")]
        public static extern HRESULT CreateDXGIFactory2(DXGI_CREATE_FACTORY_FLAGS Flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);

        [DllImport("dxgidebug")]
        public static extern HRESULT DXGIGetDebugInterface([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDebug);

        [DllImport("dxgi")]
        public static extern HRESULT DXGIGetDebugInterface1(int Flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDebug);

        public static ComObject<IDXGIDebug> DXGIGetDebugInterface()
        {
            DXGIGetDebugInterface(typeof(IDXGIDebug).GUID, out object debug).ThrowOnError();
            return new ComObject<IDXGIDebug>((IDXGIDebug)debug);
        }

        public static ComObject<IDXGIFactory> CreateDXGIFactory() => CreateDXGIFactory<IDXGIFactory>(0);
        public static ComObject<IDXGIFactory1> CreateDXGIFactory1() => CreateDXGIFactory<IDXGIFactory1>(0);
        public static ComObject<IDXGIFactory2> CreateDXGIFactory2() => CreateDXGIFactory<IDXGIFactory2>(0);
        public static ComObject<IDXGIFactory3> CreateDXGIFactory3() => CreateDXGIFactory<IDXGIFactory3>(0);
        public static ComObject<IDXGIFactory4> CreateDXGIFactory4() => CreateDXGIFactory<IDXGIFactory4>(0);
        public static ComObject<IDXGIFactory5> CreateDXGIFactory5() => CreateDXGIFactory<IDXGIFactory5>(0);
        public static ComObject<T> CreateDXGIFactory<T>() where T : IDXGIFactory => CreateDXGIFactory<T>(0);
        public static ComObject<T> CreateDXGIFactory<T>(DXGI_CREATE_FACTORY_FLAGS flags) where T : IDXGIFactory
        {
            CreateDXGIFactory2(flags, typeof(T).GUID, out object factory).ThrowOnError();
            return new ComObject<T>((T)factory);
        }
    }
}
