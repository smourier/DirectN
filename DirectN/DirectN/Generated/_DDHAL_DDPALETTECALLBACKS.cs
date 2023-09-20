// generated from <Windows SDK Path>\um\ddrawi.h
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
