// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using D3DKMDT_HVIDPN = DirectN.D3DKMDT_HVIDPN__;

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
