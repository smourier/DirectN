// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\ddrawi.h(739,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALPALCB_DESTROYPALETTE = System.IntPtr;
using LPDDHALPALCB_SETENTRIES = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DDPALETTECALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr DestroyPalette;
        public IntPtr SetEntries;
    }
}
