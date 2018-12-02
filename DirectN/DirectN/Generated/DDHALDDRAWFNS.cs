// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2048,9)
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
