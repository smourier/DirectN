using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class Api
    {
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
        public static extern HRESULT CreateDXGIFactory([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);

        [DllImport("dxgi")]
        public static extern HRESULT CreateDXGIFactory1([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);

        [DllImport("dxgi")]
        public static extern HRESULT CreateDXGIFactory2(DXGI_CREATE_FACTORY_FLAGS Flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);

        [DllImport("dxgidebug")]
        public static extern HRESULT DXGIGetDebugInterface([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDebug);

        [DllImport("dxgidebug")]
        public static extern HRESULT DXGIGetDebugInterface1(int Flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDebug);

        public static IDXGIFactory CreateDXGIFactory() => CreateDXGIFactory<IDXGIFactory>(0);
        public static IDXGIFactory1 CreateDXGIFactory1() => CreateDXGIFactory<IDXGIFactory1>(0);
        public static IDXGIFactory2 CreateDXGIFactory2() => CreateDXGIFactory<IDXGIFactory2>(0);
        public static IDXGIFactory3 CreateDXGIFactory3() => CreateDXGIFactory<IDXGIFactory3>(0);
        public static IDXGIFactory4 CreateDXGIFactory4() => CreateDXGIFactory<IDXGIFactory4>(0);
        public static IDXGIFactory5 CreateDXGIFactory5() => CreateDXGIFactory<IDXGIFactory5>(0);
        public static T CreateDXGIFactory<T>() where T : IDXGIFactory => CreateDXGIFactory<T>(0);
        public static T CreateDXGIFactory<T>(DXGI_CREATE_FACTORY_FLAGS flags) where T : IDXGIFactory
        {
            CreateDXGIFactory2(flags, typeof(T).GUID, out object factory).ThrowOnError();
            return (T)factory;
        }
    }
}
