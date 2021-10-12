// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawint.h(1744,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_FLIPTOGDISURFACEDATA
    {
        public IntPtr lpDD;
        public uint dwToGDI;
        public uint dwReserved;
        public HRESULT ddRVal;
        public IntPtr FlipToGDISurface;
    }
}
