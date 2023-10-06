// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using D3DKMDT_HVIDPN = DirectN.D3DKMDT_HVIDPN__;

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
