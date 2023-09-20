// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHALSURFCB_ADDATTACHEDSURFACE = System.IntPtr;
using LPDDHALSURFCB_BLT = System.IntPtr;
using LPDDHALSURFCB_DESTROYSURFACE = System.IntPtr;
using LPDDHALSURFCB_FLIP = System.IntPtr;
using LPDDHALSURFCB_GETBLTSTATUS = System.IntPtr;
using LPDDHALSURFCB_GETFLIPSTATUS = System.IntPtr;
using LPDDHALSURFCB_LOCK = System.IntPtr;
using LPDDHALSURFCB_SETCLIPLIST = System.IntPtr;
using LPDDHALSURFCB_SETCOLORKEY = System.IntPtr;
using LPDDHALSURFCB_SETOVERLAYPOSITION = System.IntPtr;
using LPDDHALSURFCB_SETPALETTE = System.IntPtr;
using LPDDHALSURFCB_UNLOCK = System.IntPtr;
using LPDDHALSURFCB_UPDATEOVERLAY = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DDSURFACECALLBACKS
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
