using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class Functions
    {
        public static ComObject<ID3D11Device> D3D11CreateDevice(D3D11_CREATE_DEVICE_FLAG flags) => D3D11CreateDevice(null, flags);
        public static ComObject<ID3D11Device> D3D11CreateDevice(IDXGIAdapter adapter, D3D11_CREATE_DEVICE_FLAG flags)
        {
            var levels = new D3D_FEATURE_LEVEL[]
            {
                D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_1,
                D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0,
                D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_1,
                D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_0,
                D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_3,
                D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_2,
                D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_9_1
            };
            return D3D11CreateDevice(adapter, D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE, flags, levels, D3D11Constants.D3D11_SDK_VERSION);
        }

        public static ComObject<ID3D11Device> D3D11CreateDevice(
            IDXGIAdapter adapter,
            D3D_DRIVER_TYPE driverType,
            D3D11_CREATE_DEVICE_FLAG flags,
            D3D_FEATURE_LEVEL[] featureLevels,
            int SdkVersion)
        {
            D3D11CreateDevice(
                adapter,
                driverType,
                IntPtr.Zero,
                flags,
                featureLevels,
                (featureLevels?.Length).GetValueOrDefault(),
                SdkVersion,
                out ID3D11Device device,
                out D3D_FEATURE_LEVEL level,
                out ID3D11DeviceContext dc).ThrowOnError();
            Marshal.ReleaseComObject(dc);
            return new ComObject<ID3D11Device>(device);
        }


        [DllImport("d3d11")]
        public static extern HRESULT D3D11CreateDevice(
            IDXGIAdapter pAdapter,
            D3D_DRIVER_TYPE DriverType,
            IntPtr Software,
            D3D11_CREATE_DEVICE_FLAG Flags,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] D3D_FEATURE_LEVEL[] pFeatureLevels,
            int FeatureLevels,
            int SDKVersion,
            out ID3D11Device ppDevice,
            out D3D_FEATURE_LEVEL pFeatureLevel,
            out ID3D11DeviceContext ppImmediateContext
            );

        [DllImport("d3d11")]
        public static extern HRESULT D3D11CreateDeviceAndSwapChain(
            IDXGIAdapter pAdapter,
            D3D_DRIVER_TYPE DriverType,
            IntPtr Software,
            D3D11_CREATE_DEVICE_FLAG Flags,
            [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] D3D_FEATURE_LEVEL[] pFeatureLevels,
            int FeatureLevels,
            int SDKVersion,
            ref DXGI_SWAP_CHAIN_DESC pSwapChainDesc,
            out IDXGISwapChain ppSwapChain,
            out ID3D11Device ppDevice,
            out D3D_FEATURE_LEVEL pFeatureLevel,
            out ID3D11DeviceContext ppImmediateContext
            );

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
