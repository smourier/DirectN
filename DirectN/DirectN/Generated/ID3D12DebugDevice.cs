// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3febd6dd-4973-4787-8194-e45f9e28923e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DebugDevice
    {
        [PreserveSig]
        HRESULT SetFeatureMask(D3D12_DEBUG_FEATURE Mask);
        
        [PreserveSig]
        D3D12_DEBUG_FEATURE GetFeatureMask();
        
        [PreserveSig]
        HRESULT ReportLiveDeviceObjects(D3D12_RLDO_FLAGS Flags);
    }
}
