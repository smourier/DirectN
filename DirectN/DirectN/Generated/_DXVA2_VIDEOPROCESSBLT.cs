// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva2swdev.h(60,9)
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
