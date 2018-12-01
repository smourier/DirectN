// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(595,9)
using System;
using System.Runtime.InteropServices;
using LPD3DHAL_CONTEXTCREATECB = System.IntPtr;
using LPD3DHAL_CONTEXTDESTROYALLCB = System.IntPtr;
using LPD3DHAL_CONTEXTDESTROYCB = System.IntPtr;
using LPD3DHAL_GETSTATECB = System.IntPtr;
using LPD3DHAL_RENDERPRIMITIVECB = System.IntPtr;
using LPD3DHAL_RENDERSTATECB = System.IntPtr;
using LPD3DHAL_SCENECAPTURECB = System.IntPtr;
using LPD3DHAL_TEXTURECREATECB = System.IntPtr;
using LPD3DHAL_TEXTUREDESTROYCB = System.IntPtr;
using LPD3DHAL_TEXTUREGETSURFCB = System.IntPtr;
using LPD3DHAL_TEXTURESWAPCB = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_CALLBACKS
    {
        public uint dwSize;
        public IntPtr ContextCreate;
        public IntPtr ContextDestroy;
        public IntPtr ContextDestroyAll;
        public IntPtr SceneCapture;
        public IntPtr lpReserved10;
        public IntPtr lpReserved11;
        public IntPtr RenderState;
        public IntPtr RenderPrimitive;
        public uint dwReserved;
        public IntPtr TextureCreate;
        public IntPtr TextureDestroy;
        public IntPtr TextureSwap;
        public IntPtr TextureGetSurf;
        public IntPtr lpReserved12;
        public IntPtr lpReserved13;
        public IntPtr lpReserved14;
        public IntPtr lpReserved15;
        public IntPtr lpReserved16;
        public IntPtr lpReserved17;
        public IntPtr lpReserved18;
        public IntPtr lpReserved19;
        public IntPtr lpReserved20;
        public IntPtr lpReserved21;
        public IntPtr GetState;
        public uint dwReserved0;
        public uint dwReserved1;
        public uint dwReserved2;
        public uint dwReserved3;
        public uint dwReserved4;
        public uint dwReserved5;
        public uint dwReserved6;
        public uint dwReserved7;
        public uint dwReserved8;
        public uint dwReserved9;
    }
}
