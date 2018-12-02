// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12sdklayers.h(614,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a9b71770-d099-4a65-a698-3dee10020f88"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DebugDevice1
    {
        [PreserveSig]
        HRESULT SetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, /* _In_reads_bytes_(DataSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pData, uint DataSize);
        
        [PreserveSig]
        HRESULT GetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, /* _Out_writes_bytes_(DataSize) */ IntPtr pData, uint DataSize);
        
        [PreserveSig]
        HRESULT ReportLiveDeviceObjects(D3D12_RLDO_FLAGS Flags);
    }
}
