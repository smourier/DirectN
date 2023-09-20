// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("09e0bf36-54ac-484f-8847-4baeeab6053f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DebugCommandList
    {
        [PreserveSig]
        bool AssertResourceState(/* _In_ */ ID3D12Resource pResource, uint Subresource, uint State);
        
        [PreserveSig]
        HRESULT SetFeatureMask(D3D12_DEBUG_FEATURE Mask);
        
        [PreserveSig]
        D3D12_DEBUG_FEATURE GetFeatureMask();
    }
}
