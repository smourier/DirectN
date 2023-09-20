// generated from <Windows SDK Path>\um\amvideo.h
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
