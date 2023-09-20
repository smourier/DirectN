// generated from <Windows SDK Path>\um\mfapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DIRTYRECT_INFO
    {
        public uint FrameNumber;
        public uint NumDirtyRects;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagRECT[] DirtyRects;
    }
}
