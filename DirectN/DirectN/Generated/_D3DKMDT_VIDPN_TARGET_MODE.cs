// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDPN_TARGET_MODE
    {
        public uint Id;
        public _D3DKMDT_VIDEO_SIGNAL_INFO VideoSignalInfo;
        public _D3DKMDT_VIDPN_TARGET_MODE__union_0 __union_2;
        public _D3DDDI_RATIONAL MinimumVSyncFreq;
    }
}
