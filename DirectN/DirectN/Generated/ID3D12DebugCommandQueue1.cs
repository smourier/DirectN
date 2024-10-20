// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("16be35a2-bfd6-49f2-bcae-eaae4aff862d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DebugCommandQueue1 : ID3D12DebugCommandQueue
    {
        // ID3D12DebugCommandQueue
        [PreserveSig]
        new bool AssertResourceState(/* _In_ */ ID3D12Resource pResource, uint Subresource, uint State);
        
        // ID3D12DebugCommandQueue1
        [PreserveSig]
        void AssertResourceAccess(/* _In_ */ ID3D12Resource pResource, uint Subresource, D3D12_BARRIER_ACCESS Access);
        
        [PreserveSig]
        void AssertTextureLayout(/* _In_ */ ID3D12Resource pResource, uint Subresource, D3D12_BARRIER_LAYOUT Layout);
    }
}
