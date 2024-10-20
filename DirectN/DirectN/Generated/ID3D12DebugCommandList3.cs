// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("197d5e15-4d37-4d34-af78-724cd70fdb1f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DebugCommandList3 : ID3D12DebugCommandList2
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
        new HRESULT SetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, /* _In_reads_bytes_(DataSize) */ IntPtr pData, uint DataSize);
        
        [PreserveSig]
        new HRESULT GetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, /* _Out_writes_bytes_(DataSize) */ IntPtr pData, uint DataSize);
        
        // ID3D12DebugCommandList3
        [PreserveSig]
        void AssertResourceAccess(/* _In_ */ ID3D12Resource pResource, uint Subresource, D3D12_BARRIER_ACCESS Access);
        
        [PreserveSig]
        void AssertTextureLayout(/* _In_ */ ID3D12Resource pResource, uint Subresource, D3D12_BARRIER_LAYOUT Layout);
    }
}
