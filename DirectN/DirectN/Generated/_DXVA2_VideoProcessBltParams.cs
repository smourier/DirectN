// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva2api.h(524,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_VideoProcessBltParams
    {
        public long TargetFrame;
        public tagRECT TargetRect;
        public tagSIZE ConstrictionSize;
        public uint StreamingFlags;
        public _DXVA2_AYUVSample16 BackgroundColor;
        public _DXVA2_ExtendedFormat DestFormat;
        public _DXVA2_ProcAmpValues ProcAmpValues;
        public _DXVA2_Fixed32 Alpha;
        public _DXVA2_FilterValues NoiseFilterLuma;
        public _DXVA2_FilterValues NoiseFilterChroma;
        public _DXVA2_FilterValues DetailFilterLuma;
        public _DXVA2_FilterValues DetailFilterChroma;
        public uint DestData;
    }
}
