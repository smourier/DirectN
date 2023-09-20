// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDMCBUFFERINFO
    {
        public uint dwSize;
        public IntPtr lpCompSurface;
        public uint dwDataOffset;
        public uint dwDataSize;
        public IntPtr lpPrivate;
    }
}
