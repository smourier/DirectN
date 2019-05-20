// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12sdklayers.h(721,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3febd6dd-4973-4787-8194-e45f9e28923e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
