// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHAL_SETINFO = System.IntPtr;
using LPDDHAL_VIDMEMALLOC = System.IntPtr;
using LPDDHAL_VIDMEMFREE = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DDHALDDRAWFNS
    {
        public uint dwSize;
        public IntPtr lpSetInfo;
        public IntPtr lpVidMemAlloc;
        public IntPtr lpVidMemFree;
    }
}
