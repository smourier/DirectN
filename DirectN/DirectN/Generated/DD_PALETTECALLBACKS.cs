// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(452,9)
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
