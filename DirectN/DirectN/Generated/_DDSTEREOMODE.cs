// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawi.h(1112,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSTEREOMODE
    {
        public uint dwSize;
        public uint dwHeight;
        public uint dwWidth;
        public uint dwBpp;
        public uint dwRefreshRate;
        public bool bSupported;
    }
}
