// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12sdklayers.h(1047,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("102ca951-311b-4b01-b11f-ecb83e061b37"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DebugCommandList1
    {
        [PreserveSig]
        bool AssertResourceState(/* _In_ */ ID3D12Resource pResource, uint Subresource, uint State);
        
        [PreserveSig]
        HRESULT SetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, /* _In_reads_bytes_(DataSize) */ out IntPtr pData, uint DataSize);
        
        [PreserveSig]
        HRESULT GetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, /* _Out_writes_bytes_(DataSize) */ out IntPtr pData, uint DataSize);
    }
}
