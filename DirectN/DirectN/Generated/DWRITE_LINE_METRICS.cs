// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dwrite.h(3236,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_LINE_METRICS
    {
        public uint length;
        public uint trailingWhitespaceLength;
        public uint newlineLength;
        public float height;
        public float baseline;
        public bool isTrimmed;
    }
}
