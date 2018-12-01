// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(4056,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("696442be-a72e-4059-bc79-5b5c98040fad"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Resource : ID3D12Pageable
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* _Out_writes_bytes_opt_( *pDataSize ) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* _In_reads_bytes_opt_( DataSize ) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        // ID3D12DeviceChild
        [PreserveSig]
        new HRESULT GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDevice);
        
        // ID3D12Pageable
        
        // ID3D12Resource
        [PreserveSig]
        HRESULT Map(uint Subresource, /* _In_opt_ */ ref D3D12_RANGE pReadRange, /* _Outptr_opt_result_bytebuffer_(_Inexpressible_("Dependent on resource")) */ [MarshalAs(UnmanagedType.IUnknown)] out object ppData);
        
        [PreserveSig]
        void Unmap(uint Subresource, /* _In_opt_ */ ref D3D12_RANGE pWrittenRange);
        
        [PreserveSig]
        D3D12_RESOURCE_DESC GetDesc();
        
        [PreserveSig]
        ulong GetGPUVirtualAddress();
        
        [PreserveSig]
        HRESULT WriteToSubresource(uint DstSubresource, /* _In_opt_ */ ref D3D12_BOX pDstBox, /* _In_ */ IntPtr pSrcData, uint SrcRowPitch, uint SrcDepthPitch);
        
        [PreserveSig]
        HRESULT ReadFromSubresource(/* _Out_ */ out IntPtr pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, /* _In_opt_ */ ref D3D12_BOX pSrcBox);
        
        [PreserveSig]
        HRESULT GetHeapProperties(/* _Out_opt_ */ out D3D12_HEAP_PROPERTIES pHeapProperties, /* _Out_opt_ */ out D3D12_HEAP_FLAGS pHeapFlags);
    }
}
