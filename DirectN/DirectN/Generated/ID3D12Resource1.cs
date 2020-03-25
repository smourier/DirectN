// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(14194,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9d5e227a-4430-4161-88b3-3eca6bb16e19"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Resource1 : ID3D12Resource
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
        new HRESULT Map(uint Subresource, /* optional(D3D12_RANGE) */ IntPtr pReadRange, /* optional(void) */ out IntPtr ppData);
        
        [PreserveSig]
        new void Unmap(uint Subresource, /* optional(D3D12_RANGE) */ IntPtr pWrittenRange);
        
        [PreserveSig]
        new void GetDesc(out D3D12_RESOURCE_DESC size);
        
        [PreserveSig]
        new ulong GetGPUVirtualAddress();
        
        [PreserveSig]
        new HRESULT WriteToSubresource(uint DstSubresource, /* optional(D3D12_BOX) */ IntPtr pDstBox, /* _In_ */ IntPtr pSrcData, uint SrcRowPitch, uint SrcDepthPitch);
        
        [PreserveSig]
        new HRESULT ReadFromSubresource(/* _Out_ */ out IntPtr pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, /* optional(D3D12_BOX) */ IntPtr pSrcBox);
        
        [PreserveSig]
        new HRESULT GetHeapProperties(/* optional(D3D12_HEAP_PROPERTIES) */ IntPtr pHeapProperties, /* optional(D3D12_HEAP_FLAGS) */ IntPtr pHeapFlags);
        
        // ID3D12Resource1
        [PreserveSig]
        HRESULT GetProtectedResourceSession([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppProtectedSession);
    }
}
