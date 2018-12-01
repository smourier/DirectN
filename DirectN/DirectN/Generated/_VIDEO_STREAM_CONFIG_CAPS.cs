// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(8727,9)
using System;
using System.Runtime.InteropServices;
using SIZE = DirectN.tagSIZE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VIDEO_STREAM_CONFIG_CAPS
    {
        public Guid guid;
        public uint VideoStandard;
        public SIZE InputSize;
        public SIZE MinCroppingSize;
        public SIZE MaxCroppingSize;
        public int CropGranularityX;
        public int CropGranularityY;
        public int CropAlignX;
        public int CropAlignY;
        public SIZE MinOutputSize;
        public SIZE MaxOutputSize;
        public int OutputGranularityX;
        public int OutputGranularityY;
        public int StretchTapsX;
        public int StretchTapsY;
        public int ShrinkTapsX;
        public int ShrinkTapsY;
        public long MinFrameInterval;
        public long MaxFrameInterval;
        public int MinBitsPerSecond;
        public int MaxBitsPerSecond;
    }
}
