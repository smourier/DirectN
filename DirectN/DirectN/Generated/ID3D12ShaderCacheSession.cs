// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("28e2495d-0f64-4ae4-a6ec-129255dc49a8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12ShaderCacheSession : ID3D12DeviceChild
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        // ID3D12DeviceChild
        [PreserveSig]
        new HRESULT GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDevice);
        
        // ID3D12ShaderCacheSession
        [PreserveSig]
        HRESULT FindValue(/* [annotation][in] _In_reads_bytes_(KeySize) */ IntPtr pKey, uint KeySize, /* [annotation][out] _Out_writes_bytes_(*pValueSize) */ IntPtr pValue, /* _Inout_ */ ref uint pValueSize);
        
        [PreserveSig]
        HRESULT StoreValue(/* [annotation][in] _In_reads_bytes_(KeySize) */ IntPtr pKey, uint KeySize, /* [annotation][in] _In_reads_bytes_(ValueSize) */ IntPtr pValue, uint ValueSize);
        
        [PreserveSig]
        void SetDeleteOnDestroy();
        
        [PreserveSig]
        D3D12_SHADER_CACHE_SESSION_DESC GetDesc();
    }
}
