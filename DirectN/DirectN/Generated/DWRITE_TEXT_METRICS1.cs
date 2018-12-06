// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_2.h(67,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_TEXT_METRICS1
    {
        // struct DWRITE_TEXT_METRICS
        public float left;
        public float top;
        public float width;
        public float widthIncludingTrailingWhitespace;
        public float height;
        public float layoutWidth;
        public float layoutHeight;
        public uint maxBidiReorderingDepth;
        public uint lineCount;
        
        // DWRITE_TEXT_METRICS1
        public float heightIncludingTrailingWhitespace;
    }
}
