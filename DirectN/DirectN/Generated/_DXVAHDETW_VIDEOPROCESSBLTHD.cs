// generated from <Windows SDK Path>\um\dxvahd.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDETW_VIDEOPROCESSBLTHD
    {
        public ulong pObject;
        public ulong pOutputSurface;
        public tagRECT TargetRect;
        public int OutputFormat;
        public uint ColorSpace;
        public uint OutputFrame;
        public uint StreamCount;
        public bool Enter;
    }
}
