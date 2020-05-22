// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(1154,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_LOCKDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDSurface;
        public uint bHasRect;
        public _RECTL rArea;
        public IntPtr lpSurfData;
        public HRESULT ddRVal;
        public IntPtr Lock;
        public uint dwFlags;
        public ulong fpProcess;
    }
}
