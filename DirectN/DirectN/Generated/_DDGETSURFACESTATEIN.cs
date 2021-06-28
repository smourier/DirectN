// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddkmapi.h(214,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDGETSURFACESTATEIN
    {
        public IntPtr hDirectDraw;
        public IntPtr hSurface;
    }
}
