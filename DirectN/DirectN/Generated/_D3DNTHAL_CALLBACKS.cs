// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dnthal.h(396,9)
using System;
using System.Runtime.InteropServices;
using LPD3DNTHAL_CONTEXTCREATECB = System.IntPtr;
using LPD3DNTHAL_CONTEXTDESTROYALLCB = System.IntPtr;
using LPD3DNTHAL_CONTEXTDESTROYCB = System.IntPtr;
using LPD3DNTHAL_SCENECAPTURECB = System.IntPtr;
using LPD3DNTHAL_TEXTURECREATECB = System.IntPtr;
using LPD3DNTHAL_TEXTUREDESTROYCB = System.IntPtr;
using LPD3DNTHAL_TEXTUREGETSURFCB = System.IntPtr;
using LPD3DNTHAL_TEXTURESWAPCB = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_CALLBACKS
    {
        public uint dwSize;
        public IntPtr ContextCreate;
        public IntPtr ContextDestroy;
        public IntPtr ContextDestroyAll;
        public IntPtr SceneCapture;
        public IntPtr dwReserved10;
        public IntPtr dwReserved11;
        public IntPtr dwReserved22;
        public IntPtr dwReserved23;
        public IntPtr dwReserved;
        public IntPtr TextureCreate;
        public IntPtr TextureDestroy;
        public IntPtr TextureSwap;
        public IntPtr TextureGetSurf;
        public IntPtr dwReserved12;
        public IntPtr dwReserved13;
        public IntPtr dwReserved14;
        public IntPtr dwReserved15;
        public IntPtr dwReserved16;
        public IntPtr dwReserved17;
        public IntPtr dwReserved18;
        public IntPtr dwReserved19;
        public IntPtr dwReserved20;
        public IntPtr dwReserved21;
        public IntPtr dwReserved24;
        public IntPtr dwReserved0;
        public IntPtr dwReserved1;
        public IntPtr dwReserved2;
        public IntPtr dwReserved3;
        public IntPtr dwReserved4;
        public IntPtr dwReserved5;
        public IntPtr dwReserved6;
        public IntPtr dwReserved7;
        public IntPtr dwReserved8;
        public IntPtr dwReserved9;
    }
}
