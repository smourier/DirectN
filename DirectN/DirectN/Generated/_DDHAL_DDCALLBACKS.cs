// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(701,9)
using System;
using System.Runtime.InteropServices;
using LPDDHAL_CANCREATESURFACE = System.IntPtr;
using LPDDHAL_CREATEPALETTE = System.IntPtr;
using LPDDHAL_CREATESURFACE = System.IntPtr;
using LPDDHAL_DESTROYDRIVER = System.IntPtr;
using LPDDHAL_FLIPTOGDISURFACE = System.IntPtr;
using LPDDHAL_GETSCANLINE = System.IntPtr;
using LPDDHAL_SETCOLORKEY = System.IntPtr;
using LPDDHAL_SETEXCLUSIVEMODE = System.IntPtr;
using LPDDHAL_SETMODE = System.IntPtr;
using LPDDHAL_WAITFORVERTICALBLANK = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DDCALLBACKS
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
        public IntPtr SetExclusiveMode;
        public IntPtr FlipToGDISurface;
    }
}
