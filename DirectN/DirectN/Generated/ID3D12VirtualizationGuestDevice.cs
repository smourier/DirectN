// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bc66d368-7373-4943-8757-fc87dc79e476"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VirtualizationGuestDevice
    {
        [PreserveSig]
        HRESULT ShareWithHost(/* _In_ */ ID3D12DeviceChild pObject, /* _Out_ */ out IntPtr pHandle);
        
        [PreserveSig]
        HRESULT CreateFenceFd(/* _In_ */ ID3D12Fence pFence, ulong FenceValue, /* _Out_ */ out int pFenceFd);
    }
}
