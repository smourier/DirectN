// generated from <Windows SDK Path>\um\dxva2swdev.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_VIDEOPROCESSBLT
    {
        public int TargetFrame;
        public tagRECT TargetRect;
        public tagSIZE ConstrictionSize;
        public uint StreamingFlags;
        public int BackgroundColor;
        public int DestFormat;
        public uint DestFlags;
        public int ProcAmpValues;
        public int Alpha;
        public int NoiseFilterLuma;
        public int NoiseFilterChroma;
        public int DetailFilterLuma;
        public int DetailFilterChroma;
        public IntPtr pSrcSurfaces;
        public uint NumSrcSurfaces;
    }
}
