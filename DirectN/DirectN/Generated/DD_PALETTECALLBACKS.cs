// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_PALCB_DESTROYPALETTE = System.IntPtr;
using PDD_PALCB_SETENTRIES = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DD_PALETTECALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr DestroyPalette;
        public IntPtr SetEntries;
    }
}
