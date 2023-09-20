// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __WMT_VIDEOIMAGE_SAMPLE
    {
        public uint dwMagic;
        public uint cbStruct;
        public uint dwControlFlags;
        public uint dwInputFlagsCur;
        public int lCurMotionXtoX;
        public int lCurMotionYtoX;
        public int lCurMotionXoffset;
        public int lCurMotionXtoY;
        public int lCurMotionYtoY;
        public int lCurMotionYoffset;
        public int lCurBlendCoef1;
        public int lCurBlendCoef2;
        public uint dwInputFlagsPrev;
        public int lPrevMotionXtoX;
        public int lPrevMotionYtoX;
        public int lPrevMotionXoffset;
        public int lPrevMotionXtoY;
        public int lPrevMotionYtoY;
        public int lPrevMotionYoffset;
        public int lPrevBlendCoef1;
        public int lPrevBlendCoef2;
    }
}
