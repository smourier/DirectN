// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2578,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDDDI_VPCAPS
    {
        public Guid VPGuid;
        public uint PastFrames;
        public uint FutureFrames;
        public uint ProcessorCaps;
        public uint ITelecineCaps;
        public uint CustomRateCount;
    }
}
