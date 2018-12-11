// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\amvideo.h(245,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tag_TRUECOLORINFO
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public uint[] dwBitMasks;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public tagRGBQUAD[] bmiColors;
    }
}
