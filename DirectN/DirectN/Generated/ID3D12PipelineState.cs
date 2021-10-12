// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(5063,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("765a30f3-f624-4c6f-a828-ace948622445"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12PipelineState : ID3D12Pageable
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
        
        // ID3D12Pageable
        
        // ID3D12PipelineState
        [PreserveSig]
        HRESULT GetCachedBlob(/* _COM_Outptr_ */ out ID3D10Blob ppBlob);
    }
}
