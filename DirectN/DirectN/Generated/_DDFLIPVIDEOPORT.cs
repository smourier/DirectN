// generated from <Windows SDK Path>\um\ddkmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDFLIPVIDEOPORT
    {
        public IntPtr hDirectDraw;
        public IntPtr hVideoPort;
        public IntPtr hCurrentSurface;
        public IntPtr hTargetSurface;
        public uint dwFlags;
    }
}
