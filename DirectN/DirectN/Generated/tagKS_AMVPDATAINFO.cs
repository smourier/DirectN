// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_AMVPDATAINFO
    {
        public uint dwSize;
        public uint dwMicrosecondsPerField;
        public tagKS_AMVPDIMINFO amvpDimInfo;
        public uint dwPictAspectRatioX;
        public uint dwPictAspectRatioY;
        public bool bEnableDoubleClock;
        public bool bEnableVACT;
        public bool bDataIsInterlaced;
        public int lHalfLinesOdd;
        public bool bFieldPolarityInverted;
        public uint dwNumLinesInVREF;
        public int lHalfLinesEven;
        public uint dwReserved1;
    }
}
