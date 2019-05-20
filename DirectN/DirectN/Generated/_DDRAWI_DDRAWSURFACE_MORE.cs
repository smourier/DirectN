// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawi.h(1439,9)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWCLIPPER_INT = DirectN._DDRAWI_DDRAWCLIPPER_INT;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DDVIDEOPORT_LCL = DirectN._DDRAWI_DDVIDEOPORT_LCL;
using LPDDRAWI_DIRECTDRAW_INT = DirectN._DDRAWI_DIRECTDRAW_INT;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;
using LPDDSURFACEDESC2 = DirectN._DDSURFACEDESC2;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWSURFACE_MORE
    {
        public uint dwSize;
        public IntPtr lpIUnknowns;
        public IntPtr lpDD_lcl;
        public uint dwPageLockCount;
        public uint dwBytesAllocated;
        public IntPtr lpDD_int;
        public uint dwMipMapCount;
        public IntPtr lpDDIClipper;
        public IntPtr lpHeapAliasInfo;
        public uint dwOverlayFlags;
        public IntPtr rgjunc;
        public IntPtr lpVideoPort;
        public IntPtr lpddOverlayFX;
        public _DDSCAPSEX ddsCapsEx;
        public uint dwTextureStage;
        public IntPtr lpDDRAWReserved;
        public IntPtr lpDDRAWReserved2;
        public IntPtr lpDDrawReserved3;
        public uint dwDDrawReserved4;
        public IntPtr lpDDrawReserved5;
        public IntPtr lpGammaRamp;
        public IntPtr lpOriginalGammaRamp;
        public IntPtr lpDDrawReserved6;
        public uint dwSurfaceHandle;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public uint[] qwDDrawReserved8;
        public IntPtr lpDDrawReserved9;
        public uint cSurfaces;
        public IntPtr pCreatedDDSurfaceDesc2;
        public IntPtr slist;
        public uint dwFVF;
        public IntPtr lpVB;
    }
}
