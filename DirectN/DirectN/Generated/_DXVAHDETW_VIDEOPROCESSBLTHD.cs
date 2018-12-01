// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxvahd.h(1071,9)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDETW_VIDEOPROCESSBLTHD
    {
        public ulong pObject;
        public ulong pOutputSurface;
        public RECT TargetRect;
        public int OutputFormat;
        public uint ColorSpace;
        public uint OutputFrame;
        public uint StreamCount;
        public bool Enter;
    }
}
