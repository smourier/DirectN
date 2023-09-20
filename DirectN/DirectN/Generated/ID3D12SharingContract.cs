// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0adf7d52-929c-4e61-addb-ffed30de66ef"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12SharingContract
    {
        [PreserveSig]
        void Present(/* _In_ */ ID3D12Resource pResource, uint Subresource, /* _In_ */ IntPtr window);
        
        [PreserveSig]
        void SharedFenceSignal(/* _In_ */ ID3D12Fence pFence, ulong FenceValue);
        
        [PreserveSig]
        void BeginCapturableWork(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid);
        
        [PreserveSig]
        void EndCapturableWork(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid);
    }
}
