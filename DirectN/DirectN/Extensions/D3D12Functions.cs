using System;
using System.ComponentModel;
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

        public static IComObject<ID3D10Blob> D3D12SerializeRootSignature(D3D12_ROOT_SIGNATURE_DESC rootSignature, D3D_ROOT_SIGNATURE_VERSION version = D3D_ROOT_SIGNATURE_VERSION.D3D_ROOT_SIGNATURE_VERSION_1)
        {
            var hr = D3D12SerializeRootSignature(ref rootSignature, version, out var blob, out var errorBlob);
            if (errorBlob != null)
            {
                var str = errorBlob.GetAnsiStringFromBlob();
                if (str != null)
                    throw new Win32Exception(hr.Value, str);

                throw new Win32Exception(hr.Value);
            }
            return new ComObject<ID3D10Blob>(blob);
        }

        public static IComObject<ID3D10Blob> D3D12SerializeRootSignature(D3D12_VERSIONED_ROOT_SIGNATURE_DESC rootSignature)
        {
            var hr = D3D12SerializeVersionedRootSignature(ref rootSignature, out var blob, out var errorBlob);
            if (errorBlob != null)
            {
                var str = errorBlob.GetAnsiStringFromBlob();
                if (str != null)
                    throw new Win32Exception(hr.Value, str);

                throw new Win32Exception(hr.Value);
            }

            hr.ThrowOnError();
            return new ComObject<ID3D10Blob>(blob);
        }

        public static IComObject<ID3D12RootSignatureDeserializer> D3D12CreateRootSignatureDeserializer(IntPtr srcData, IntPtr srcDataSizeInBytes)
        {
            D3D12CreateRootSignatureDeserializer(srcData, srcDataSizeInBytes, typeof(ID3D12RootSignatureDeserializer).GUID, out var deserializer).ThrowOnError();
            return new ComObject<ID3D12RootSignatureDeserializer>((ID3D12RootSignatureDeserializer)deserializer);
        }

        public static IComObject<ID3D12VersionedRootSignatureDeserializer> D3D12CreateVersionedRootSignatureDeserializer(IntPtr srcData, IntPtr srcDataSizeInBytes)
        {
            D3D12CreateVersionedRootSignatureDeserializer(srcData, srcDataSizeInBytes, typeof(ID3D12VersionedRootSignatureDeserializer).GUID, out var deserializer).ThrowOnError();
            return new ComObject<ID3D12VersionedRootSignatureDeserializer>((ID3D12VersionedRootSignatureDeserializer)deserializer);
        }

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12CreateDevice([MarshalAs(UnmanagedType.IUnknown)] object adapter, D3D_FEATURE_LEVEL minimumFeatureLevel, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDevice);

        [DllImport("d3d12", ExactSpelling = true)]
        private static extern HRESULT D3D12CreateDevice([MarshalAs(UnmanagedType.IUnknown)] object adapter, D3D_FEATURE_LEVEL minimumFeatureLevel, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, IntPtr ppDevice);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12GetInterface([MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppDevice);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12GetDebugInterface([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvDebug);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12SerializeRootSignature(ref D3D12_ROOT_SIGNATURE_DESC pRootSignature, D3D_ROOT_SIGNATURE_VERSION Version, out ID3D10Blob ppBlob, out ID3D10Blob ppErrorBlob);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12SerializeVersionedRootSignature(ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC pRootSignature, out ID3D10Blob ppBlob, out ID3D10Blob ppErrorBlob);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12CreateRootSignatureDeserializer(IntPtr pSrcData, IntPtr SrcDataSizeInBytes, [MarshalAs(UnmanagedType.LPStruct)] Guid pRootSignatureDeserializerInterface, [MarshalAs(UnmanagedType.IUnknown)] out object ppRootSignatureDeserializer);

        [DllImport("d3d12", ExactSpelling = true)]
        public static extern HRESULT D3D12CreateVersionedRootSignatureDeserializer(IntPtr pSrcData, IntPtr SrcDataSizeInBytes, [MarshalAs(UnmanagedType.LPStruct)] Guid pRootSignatureDeserializerInterface, [MarshalAs(UnmanagedType.IUnknown)] out object ppRootSignatureDeserializer);
    }
}
