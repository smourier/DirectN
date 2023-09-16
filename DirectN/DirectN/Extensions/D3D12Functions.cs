using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class D3D12Functions
    {
        public static IComObject<ID3D12Device> D3D12CreateDevice(IComObject<object> adapter, D3D_FEATURE_LEVEL minimumFeatureLevel = D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0) => D3D12CreateDevice<ID3D12Device>(adapter?.Object, minimumFeatureLevel);
        public static IComObject<T> D3D12CreateDevice<T>(object adapter, D3D_FEATURE_LEVEL minimumFeatureLevel = D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0) where T : ID3D12Device
        {
            D3D12CreateDevice(adapter, minimumFeatureLevel, typeof(T).GUID, out var dev).ThrowOnError();
            return new ComObject<T>((T)dev);
        }

        public static HRESULT D3D12CheckDeviceCreate(object adapter, D3D_FEATURE_LEVEL minimumFeatureLevel = D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0) => D3D12CheckDeviceCreate<ID3D12Device>(adapter, minimumFeatureLevel);
        public static HRESULT D3D12CheckDeviceCreate<T>(object adapter, D3D_FEATURE_LEVEL minimumFeatureLevel = D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0) where T : ID3D12Device => D3D12CreateDevice(ComObject.Unwrap(adapter), minimumFeatureLevel, typeof(T).GUID, IntPtr.Zero);

        public static IComObject<T> D3D12GetInterface<T>(Guid rclsid)
        {
            D3D12GetInterface(rclsid, typeof(T).GUID, out var dev).ThrowOnError();
            return new ComObject<T>((T)dev);
        }

        public static IComObject<T> D3D12GetDebugInterface<T>()
        {
            D3D12GetDebugInterface(typeof(T).GUID, out var dev).ThrowOnError();
            return new ComObject<T>((T)dev);
        }

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12CreateDevice([MarshalAs(UnmanagedType.IUnknown)] object adapter, D3D_FEATURE_LEVEL minimumFeatureLevel, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDevice);

        [DllImport("d3d12", ExactSpelling = true)]
        private static extern HRESULT D3D12CreateDevice([MarshalAs(UnmanagedType.IUnknown)] object adapter, D3D_FEATURE_LEVEL minimumFeatureLevel, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, IntPtr ppDevice);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12GetInterface([MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDevice);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12GetDebugInterface([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvDebug);
    }
}
