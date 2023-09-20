// generated from <Windows SDK Path>\um\ddraw.h
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
