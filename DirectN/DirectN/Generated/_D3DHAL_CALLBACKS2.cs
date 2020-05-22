// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dhal.h(799,9)
using System;
using System.Runtime.InteropServices;
using LPD3DHAL_CLEARCB = System.IntPtr;
using LPD3DHAL_DRAWONEINDEXEDPRIMITIVECB = System.IntPtr;
using LPD3DHAL_DRAWONEPRIMITIVECB = System.IntPtr;
using LPD3DHAL_DRAWPRIMITIVESCB = System.IntPtr;
using LPD3DHAL_SETRENDERTARGETCB = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_CALLBACKS2
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr SetRenderTarget;
        public IntPtr Clear;
        public IntPtr DrawOnePrimitive;
        public IntPtr DrawOneIndexedPrimitive;
        public IntPtr DrawPrimitives;
    }
}
