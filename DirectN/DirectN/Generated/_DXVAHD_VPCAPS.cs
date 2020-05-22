// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxvahd.h(307,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_VPCAPS
    {
        public Guid VPGuid;
        public uint PastFrames;
        public uint FutureFrames;
        public uint ProcessorCaps;
        public uint ITelecineCaps;
        public uint CustomRateCount;
    }
}
