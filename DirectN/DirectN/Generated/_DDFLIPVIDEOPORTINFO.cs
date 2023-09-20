// generated from <Windows SDK Path>\um\dxmini.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDFLIPVIDEOPORTINFO
    {
        public IntPtr lpVideoPortData;
        public IntPtr lpCurrentSurface;
        public IntPtr lpTargetSurface;
        public uint dwFlipVPFlags;
    }
}
