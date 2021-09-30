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

        public static void DXGIReportLiveObjects(DXGI_DEBUG_RLO_FLAGS flags = DXGI_DEBUG_RLO_FLAGS.DXGI_DEBUG_RLO_ALL) => DXGIReportLiveObjects(DXGIConstants.DXGI_DEBUG_ALL, flags);
        public static void DXGIReportLiveObjects(Guid apiid, DXGI_DEBUG_RLO_FLAGS flags = DXGI_DEBUG_RLO_FLAGS.DXGI_DEBUG_RLO_ALL)
        {
            if (!IsDebugLayerAvailable)
                return;

            DXGIGetDebugInterface(typeof(IDXGIDebug).GUID, out var debug);
            if (!(debug is IDXGIDebug dbg))
                return;

            dbg.ReportLiveObjects(apiid, flags);
            Marshal.ReleaseComObject(debug);
        }

        [DllImport("dxgi", ExactSpelling = true)]
        public static extern HRESULT DXGIDeclareAdapterRemovalSupport();

        [DllImport("dxgi", ExactSpelling = true)]
        public static extern HRESULT CreateDXGIFactory([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);

        [DllImport("dxgi", ExactSpelling = true)]
        public static extern HRESULT CreateDXGIFactory1([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);

        [DllImport("dxgi", ExactSpelling = true)]
        public static extern HRESULT CreateDXGIFactory2(DXGI_CREATE_FACTORY_FLAGS Flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);

        [DllImport("dxgidebug", ExactSpelling = true)]
        public static extern HRESULT DXGIGetDebugInterface([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDebug);

        [DllImport("dxgi", ExactSpelling = true)]
        public static extern HRESULT DXGIGetDebugInterface1(int Flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDebug);

        public static IComObject<IDXGIDebug> DXGIGetDebugInterface()
        {
            if (DXGIGetDebugInterface(typeof(IDXGIDebug).GUID, out var debug).IsError)
                return null;

            return new ComObject<IDXGIDebug>((IDXGIDebug)debug);
        }

        public static IComObject<IDXGIDebug1> DXGIGetDebugInterface1()
        {
            if (DXGIGetDebugInterface(typeof(IDXGIDebug1).GUID, out var debug).IsError)
                return null;

            return new ComObject<IDXGIDebug1>((IDXGIDebug1)debug);
        }

        public static IComObject<IDXGIFactory2> CreateDXGIFactory2(DXGI_CREATE_FACTORY_FLAGS flags = DXGI_CREATE_FACTORY_FLAGS.DXGI_CREATE_FACTORY_NONE) => CreateDXGIFactory2<IDXGIFactory2>(flags);
        public static IComObject<T> CreateDXGIFactory2<T>(DXGI_CREATE_FACTORY_FLAGS flags = DXGI_CREATE_FACTORY_FLAGS.DXGI_CREATE_FACTORY_NONE) where T : IDXGIFactory2
        {
            CreateDXGIFactory2(flags, typeof(T).GUID, out var factory).ThrowOnError();
            return new ComObject<T>((T)factory);
        }

        public static IComObject<IDXGIFactory1> CreateDXGIFactory1() => CreateDXGIFactory1<IDXGIFactory1>();
        public static IComObject<T> CreateDXGIFactory1<T>() where T : IDXGIFactory1
        {
            CreateDXGIFactory1(typeof(T).GUID, out var factory).ThrowOnError();
            var f2 = (T)factory;
            return new ComObject<T>(f2);
        }

        // https://docs.microsoft.com/en-us/windows/desktop/api/d3d11/nf-d3d11-d3d11createdevice
        // Note  Do not mix the use of DXGI 1.0 (IDXGIFactory) and DXGI 1.1 (IDXGIFactory1) in an application.
        // Use IDXGIFactory or IDXGIFactory1, but not both in an application.
        //public static ComObject<IDXGIFactory> CreateDXGIFactory() => CreateDXGIFactory<IDXGIFactory>();
        //public static ComObject<T> CreateDXGIFactory<T>() where T : IDXGIFactory
        //{
        //    CreateDXGIFactory(typeof(T).GUID, out object factory).ThrowOnError();
        //    return new ComObject<T>((T)factory);
        //}
    }
}
