// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_COMMITVIDPN
    {
        public IntPtr hFunctionalVidPn;
        public uint AffectedVidPnSourceId;
        public _D3DKMDT_MONITOR_CONNECTIVITY_CHECKS MonitorConnectivityChecks;
        public IntPtr hPrimaryAllocation;
        public _DXGKARG_COMMITVIDPN_FLAGS Flags;
    }
}
