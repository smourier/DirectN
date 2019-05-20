// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(621,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_LOCKASYNC
    {
        public IntPtr hResource;
        public uint SubResourceIndex;
        public _D3DDDI_LOCKASYNCFLAGS Flags;
        public _D3DDDIARG_LOCKASYNC__union_0 __union_3;
        public IntPtr hCookie;
        public IntPtr pSurfData;
        public uint Pitch;
        public uint SlicePitch;
        public ulong GpuVirtualAddress;
    }
}
