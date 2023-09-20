// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a9b71770-d099-4a65-a698-3dee10020f88"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12DebugDevice1
    {
        [PreserveSig]
        HRESULT SetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, /* _In_reads_bytes_(DataSize) */ IntPtr pData, uint DataSize);
        
        [PreserveSig]
        HRESULT GetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, /* _Out_writes_bytes_(DataSize) */ IntPtr pData, uint DataSize);
        
        [PreserveSig]
        HRESULT ReportLiveDeviceObjects(D3D12_RLDO_FLAGS Flags);
    }
}
