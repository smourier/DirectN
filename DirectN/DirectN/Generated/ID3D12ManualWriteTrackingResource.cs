// generated from <Windows SDK Path>\um\d3d12sdklayers.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("86ca3b85-49ad-4b6e-aed5-eddb18540f41"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12ManualWriteTrackingResource
    {
        [PreserveSig]
        void TrackWrite(uint Subresource, /* optional(D3D12_RANGE) */ IntPtr pWrittenRange);
    }
}
