// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(4670,5)
using System;
using System.Runtime.InteropServices;
using ID3DBlob = DirectN.ID3D10Blob;

namespace DirectN
{
    [Guid("765a30f3-f624-4c6f-a828-ace948622445"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12PipelineState : ID3D12Pageable
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* _Out_writes_bytes_opt_( *pDataSize ) */ [MarshalAs(UnmanagedType.IUnknown)] out object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* _In_reads_bytes_opt_( DataSize ) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        // ID3D12DeviceChild
        [PreserveSig]
        new HRESULT GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDevice);
        
        // ID3D12Pageable
        
        // ID3D12PipelineState
        [PreserveSig]
        HRESULT GetCachedBlob(/* _COM_Outptr_ */ out ID3DBlob ppBlob);
    }
}
