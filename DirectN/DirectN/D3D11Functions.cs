using System;
using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;

namespace DirectN
{
    public static class D3D11Functions
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
    }
}
