// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddkmapi.h(293,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDFLIPOVERLAY
    {
        public IntPtr hDirectDraw;
        public IntPtr hCurrentSurface;
        public IntPtr hTargetSurface;
        public uint dwFlags;
    }
}
