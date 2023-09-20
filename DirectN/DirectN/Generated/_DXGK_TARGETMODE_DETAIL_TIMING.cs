// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_TARGETMODE_DETAIL_TIMING
    {
        public _D3DKMDT_VIDEO_SIGNAL_STANDARD VideoStandard;
        public uint TimingId;
        public _DISPLAYID_DETAILED_TIMING_TYPE_I DetailTiming;
    }
}
