// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(3124,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_UNDERLINE
    {
        public float width;
        public float thickness;
        public float offset;
        public float runHeight;
        public DWRITE_READING_DIRECTION readingDirection;
        public DWRITE_FLOW_DIRECTION flowDirection;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char localeName;
        public DWRITE_MEASURING_MODE measuringMode;
    }
}
