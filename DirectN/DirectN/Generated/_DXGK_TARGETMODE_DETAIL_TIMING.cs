// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmdt.h(716,9)
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
