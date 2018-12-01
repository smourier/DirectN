// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12sdklayers.h(818,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("60eccbc1-378d-4df1-894c-f8ac5ce4d7dd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DebugDevice2 : ID3D12DebugDevice
    {
        // ID3D12DebugDevice
        [PreserveSig]
        new HRESULT SetFeatureMask(D3D12_DEBUG_FEATURE Mask);
        
        [PreserveSig]
        new D3D12_DEBUG_FEATURE GetFeatureMask();
        
        [PreserveSig]
        new HRESULT ReportLiveDeviceObjects(D3D12_RLDO_FLAGS Flags);
        
        // ID3D12DebugDevice2
        [PreserveSig]
        HRESULT SetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, /* _In_reads_bytes_(DataSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pData, uint DataSize);
        
        [PreserveSig]
        HRESULT GetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, /* _Out_writes_bytes_(DataSize) */ [MarshalAs(UnmanagedType.IUnknown)] out object pData, uint DataSize);
    }
}
