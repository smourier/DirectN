// generated from <Windows SDK Path>\um\d3d12compatibility.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8f1c0e3c-fae3-4a82-b098-bfe1708207ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12CompatibilityDevice
    {
        [PreserveSig]
        HRESULT CreateSharedResource(/* _In_ */ ref D3D12_HEAP_PROPERTIES pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, /* _In_ */ ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialResourceState, /* optional(D3D12_CLEAR_VALUE) */ IntPtr pOptimizedClearValue, /* optional(D3D11_RESOURCE_FLAGS) */ IntPtr pFlags11, D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags, /* _In_opt_ */ ID3D12LifetimeTracker pLifetimeTracker, /* _In_opt_ */ ID3D12SwapChainAssistant pOwningSwapchain, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppResource);
        
        [PreserveSig]
        HRESULT CreateSharedHeap(/* _In_ */ ref D3D12_HEAP_DESC pHeapDesc, D3D12_COMPATIBILITY_SHARED_FLAGS CompatibilityFlags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppHeap);
        
        [PreserveSig]
        HRESULT ReflectSharedProperties(/* _In_ */ ID3D12Object pHeapOrResource, D3D12_REFLECT_SHARED_PROPERTY ReflectType, /* _Out_writes_bytes_(DataSize) */ IntPtr pData, uint DataSize);
    }
}
