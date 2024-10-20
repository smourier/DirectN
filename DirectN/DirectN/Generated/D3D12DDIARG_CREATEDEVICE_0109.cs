// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATEDEVICE_0109
    {
        public D3D10DDI_HRTDEVICE hRTDevice;
        public uint Interface;
        public uint Version;
        public IntPtr pKTCallbacks;
        public D3D10DDI_HDEVICE hDrvDevice;
        public D3D12DDIARG_CREATEDEVICE_0109__union_0 __union_5;
        public D3D12DDI_CREATE_DEVICE_FLAGS Flags;
        public IntPtr pReserveRanges;
        public uint NumReserveRanges;
    }
}
