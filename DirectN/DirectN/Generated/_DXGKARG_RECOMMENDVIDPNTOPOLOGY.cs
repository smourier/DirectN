// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using D3DKMDT_HVIDPN = DirectN.D3DKMDT_HVIDPN__;
using D3DKMDT_HVIDPNTOPOLOGY = DirectN.D3DKMDT_HVIDPNTOPOLOGY__;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_RECOMMENDVIDPNTOPOLOGY
    {
        public IntPtr hVidPn;
        public uint VidPnSourceId;
        public _DXGK_RECOMMENDVIDPNTOPOLOGY_REASON RequestReason;
        public IntPtr hFallbackTopology;
    }
}
