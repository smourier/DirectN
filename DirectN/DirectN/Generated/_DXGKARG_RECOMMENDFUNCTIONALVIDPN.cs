// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(5148,9)
using System;
using System.Runtime.InteropServices;
using D3DDDI_VIDEO_PRESENT_TARGET_ID = System.UInt32;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_RECOMMENDFUNCTIONALVIDPN
    {
        public uint NumberOfVidPnTargets;
        public IntPtr pVidPnTargetPrioritizationVector;
        public IntPtr hRecommendedFunctionalVidPn;
        public _DXGK_RECOMMENDFUNCTIONALVIDPN_REASON RequestReason;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}
