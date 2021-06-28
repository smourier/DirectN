// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddraw.h(2480,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDCOLORCONTROL
    {
        public uint dwSize;
        public uint dwFlags;
        public int lBrightness;
        public int lContrast;
        public int lHue;
        public int lSaturation;
        public int lSharpness;
        public int lGamma;
        public int lColorEnable;
        public uint dwReserved1;
    }
}
