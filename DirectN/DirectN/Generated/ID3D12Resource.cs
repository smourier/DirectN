// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("696442be-a72e-4059-bc79-5b5c98040fad"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
        HRESULT Map(uint Subresource, /* optional(D3D12_RANGE) */ IntPtr pReadRange, /* optional(void) */ out IntPtr ppData);

        [PreserveSig]
        void Unmap(uint Subresource, /* optional(D3D12_RANGE) */ IntPtr pWrittenRange);

        [PreserveSig]
        void GetDesc(out D3D12_RESOURCE_DESC size);

        [PreserveSig]
        ulong GetGPUVirtualAddress();

        [PreserveSig]
        HRESULT WriteToSubresource(uint DstSubresource, /* optional(D3D12_BOX) */ IntPtr pDstBox, /* _In_ */ IntPtr pSrcData, uint SrcRowPitch, uint SrcDepthPitch);

        [PreserveSig]
        HRESULT ReadFromSubresource(/* _Out_ */ IntPtr pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, /* optional(D3D12_BOX) */ IntPtr pSrcBox);

        [PreserveSig]
        HRESULT GetHeapProperties(/* optional(D3D12_HEAP_PROPERTIES) */ IntPtr pHeapProperties, /* optional(D3D12_HEAP_FLAGS) */ IntPtr pHeapFlags);
    }
}
