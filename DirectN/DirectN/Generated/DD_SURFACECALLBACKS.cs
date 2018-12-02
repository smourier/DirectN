// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(483,9)
using System;
using System.Runtime.InteropServices;
using PDD_SURFCB_ADDATTACHEDSURFACE = System.IntPtr;
using PDD_SURFCB_BLT = System.IntPtr;
using PDD_SURFCB_DESTROYSURFACE = System.IntPtr;
using PDD_SURFCB_FLIP = System.IntPtr;
using PDD_SURFCB_GETBLTSTATUS = System.IntPtr;
using PDD_SURFCB_GETFLIPSTATUS = System.IntPtr;
using PDD_SURFCB_LOCK = System.IntPtr;
using PDD_SURFCB_SETCLIPLIST = System.IntPtr;
using PDD_SURFCB_SETCOLORKEY = System.IntPtr;
using PDD_SURFCB_SETOVERLAYPOSITION = System.IntPtr;
using PDD_SURFCB_SETPALETTE = System.IntPtr;
using PDD_SURFCB_UNLOCK = System.IntPtr;
using PDD_SURFCB_UPDATEOVERLAY = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DD_SURFACECALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr DestroySurface;
        public IntPtr Flip;
        public IntPtr SetClipList;
        public IntPtr Lock;
        public IntPtr Unlock;
        public IntPtr Blt;
        public IntPtr SetColorKey;
        public IntPtr AddAttachedSurface;
        public IntPtr GetBltStatus;
        public IntPtr GetFlipStatus;
        public IntPtr UpdateOverlay;
        public IntPtr SetOverlayPosition;
        public IntPtr reserved4;
        public IntPtr SetPalette;
    }
}
