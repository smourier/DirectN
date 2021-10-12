// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(6336,9)
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
