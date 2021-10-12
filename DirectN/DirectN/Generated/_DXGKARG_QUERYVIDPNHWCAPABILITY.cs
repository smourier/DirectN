// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(7446,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_QUERYVIDPNHWCAPABILITY
    {
        public IntPtr hFunctionalVidPn;
        public uint SourceId;
        public uint TargetId;
        public _D3DKMDT_VIDPN_HW_CAPABILITY VidPnHWCaps;
    }
}
