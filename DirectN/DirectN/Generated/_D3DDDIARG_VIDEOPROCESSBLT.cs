// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(1320,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_VIDEOPROCESSBLT
    {
        public long TargetFrame;
        public IntPtr hVideoProcess;
        public tagRECT TargetRect;
        public tagSIZE ConstrictionSize;
        public uint StreamingFlags;
        public _DXVADDI_AYUVSAMPLE16 BackgroundColor;
        public _DXVADDI_EXTENDEDFORMAT DestFormat;
        public _DXVADDI_VIDEOPROCESSBLTFLAGS DestFlags;
        public _DXVADDI_PROCAMPVALUES ProcAmpValues;
        public _DXVADDI_FIXED32 Alpha;
        public _DXVADDI_FILTERVALUES NoiseFilterLuma;
        public _DXVADDI_FILTERVALUES NoiseFilterChroma;
        public _DXVADDI_FILTERVALUES DetailFilterLuma;
        public _DXVADDI_FILTERVALUES DetailFilterChroma;
        public IntPtr pSrcSurfaces;
        public uint NumSrcSurfaces;
    }
}
