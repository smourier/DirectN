// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(1045,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_STEREOMODE
    {
        public uint dwSize;
        public uint dwHeight;
        public uint dwWidth;
        public uint dwBpp;
        public uint dwRefreshRate;
        public bool bSupported;
    }
}
