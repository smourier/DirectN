// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dwrite.h(3450,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_HIT_TEST_METRICS
    {
        public uint textPosition;
        public uint length;
        public float left;
        public float top;
        public float width;
        public float height;
        public uint bidiLevel;
        public bool isText;
        public bool isTrimmed;
    }
}
