using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class Api
    {
        [DllImport("d3d11")]
        public static extern int D3D11CreateDevice(
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
        public static extern int D3D11CreateDeviceAndSwapChain(
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
        public static extern int CreateDXGIFactory([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);

        [DllImport("dxgi")]
        public static extern int CreateDXGIFactory1([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);

        [DllImport("dxgi")]
        public static extern int CreateDXGIFactory2(DXGI_CREATE_FACTORY_FLAGS Flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppFactory);

        [DllImport("dxgidebug")]
        public static extern int DXGIGetDebugInterface([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDebug);

        [DllImport("dxgidebug")]
        public static extern int DXGIGetDebugInterface1(int Flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDebug);
    }
}
