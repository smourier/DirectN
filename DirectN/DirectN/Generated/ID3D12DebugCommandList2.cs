// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("aeb575cf-4e06-48be-ba3b-c450fc96652e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DebugCommandList2 : ID3D12DebugCommandList
    {
        // ID3D12DebugCommandList
        [PreserveSig]
        new bool AssertResourceState(/* _In_ */ ID3D12Resource pResource, uint Subresource, uint State);
        
        [PreserveSig]
        new HRESULT SetFeatureMask(D3D12_DEBUG_FEATURE Mask);
        
        [PreserveSig]
        new D3D12_DEBUG_FEATURE GetFeatureMask();
        
        // ID3D12DebugCommandList2
        [PreserveSig]
        HRESULT SetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, /* _In_reads_bytes_(DataSize) */ IntPtr pData, uint DataSize);
        
        [PreserveSig]
        HRESULT GetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, /* _Out_writes_bytes_(DataSize) */ IntPtr pData, uint DataSize);
    }
}
