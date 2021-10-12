// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(552,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_LOCK
    {
        public IntPtr hResource;
        public uint SubResourceIndex;
        public _D3DDDIARG_LOCK__union_0 __union_2;
        public IntPtr pSurfData;
        public uint Pitch;
        public uint SlicePitch;
        public _D3DDDI_LOCKFLAGS Flags;
    }
}
