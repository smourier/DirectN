// generated from <Windows SDK Path>\um\dxvahd.h
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
