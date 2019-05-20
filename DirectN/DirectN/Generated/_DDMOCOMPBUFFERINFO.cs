// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawint.h(1908,9)
using System;
using System.Runtime.InteropServices;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDMOCOMPBUFFERINFO
    {
        public uint dwSize;
        public IntPtr lpCompSurface;
        public uint dwDataOffset;
        public uint dwDataSize;
        public IntPtr lpPrivate;
    }
}
