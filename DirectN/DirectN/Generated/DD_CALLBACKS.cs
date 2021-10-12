// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawint.h(360,9)
using System;
using System.Runtime.InteropServices;
using PDD_CANCREATESURFACE = System.IntPtr;
using PDD_CREATEPALETTE = System.IntPtr;
using PDD_CREATESURFACE = System.IntPtr;
using PDD_DESTROYDRIVER = System.IntPtr;
using PDD_GETSCANLINE = System.IntPtr;
using PDD_MAPMEMORY = System.IntPtr;
using PDD_SETCOLORKEY = System.IntPtr;
using PDD_SETMODE = System.IntPtr;
using PDD_WAITFORVERTICALBLANK = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DD_CALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr DestroyDriver;
        public IntPtr CreateSurface;
        public IntPtr SetColorKey;
        public IntPtr SetMode;
        public IntPtr WaitForVerticalBlank;
        public IntPtr CanCreateSurface;
        public IntPtr CreatePalette;
        public IntPtr GetScanLine;
        public IntPtr MapMemory;
    }
}
