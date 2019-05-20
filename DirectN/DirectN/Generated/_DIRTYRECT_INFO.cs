// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfapi.h(1191,9)
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
