// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("102ca951-311b-4b01-b11f-ecb83e061b37"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DebugCommandList1
    {
        [PreserveSig]
        bool AssertResourceState(/* _In_ */ ID3D12Resource pResource, uint Subresource, uint State);
        
        [PreserveSig]
        HRESULT SetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, /* _In_reads_bytes_(DataSize) */ IntPtr pData, uint DataSize);
        
        [PreserveSig]
        HRESULT GetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, /* _Out_writes_bytes_(DataSize) */ IntPtr pData, uint DataSize);
    }
}
