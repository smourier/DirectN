// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(8593,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETTIMINGSFROMVIDPN
    {
        public IntPtr hFunctionalVidPn;
        public _DXGK_SET_TIMING_FLAGS SetFlags;
        public IntPtr pResultsFlags;
        public uint PathCount;
        public IntPtr pSetTimingPathInfo;
    }
}
