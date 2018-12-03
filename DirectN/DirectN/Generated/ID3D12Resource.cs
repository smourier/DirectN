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
        
        // ID3D12Resource
        [PreserveSig]
        HRESULT Map(uint Subresource, /* optional(D3D12_RANGE) */ IntPtr pReadRange, /* _Outptr_opt_result_bytebuffer_(_Inexpressible_("Dependent on resource")) */ [MarshalAs(UnmanagedType.IUnknown)] out object ppData);
        
        [PreserveSig]
        void Unmap(uint Subresource, /* optional(D3D12_RANGE) */ IntPtr pWrittenRange);
        
        [PreserveSig]
        D3D12_RESOURCE_DESC GetDesc();
        
        [PreserveSig]
        ulong GetGPUVirtualAddress();
        
        [PreserveSig]
        HRESULT WriteToSubresource(uint DstSubresource, /* optional(D3D12_BOX) */ IntPtr pDstBox, /* _In_ */ IntPtr pSrcData, uint SrcRowPitch, uint SrcDepthPitch);
        
        [PreserveSig]
        HRESULT ReadFromSubresource(/* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, /* optional(D3D12_BOX) */ IntPtr pSrcBox);
        
        [PreserveSig]
        HRESULT GetHeapProperties(/* _Out_opt_ */ out D3D12_HEAP_PROPERTIES pHeapProperties, /* _Out_opt_ */ out D3D12_HEAP_FLAGS pHeapFlags);
    }
}
