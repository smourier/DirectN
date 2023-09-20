// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHALSURFCB_SETOVERLAYPOSITION = System.IntPtr;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_SETOVERLAYPOSITIONDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDSrcSurface;
        public IntPtr lpDDDestSurface;
        public int lXPos;
        public int lYPos;
        public HRESULT ddRVal;
        public IntPtr SetOverlayPosition;
    }
}
