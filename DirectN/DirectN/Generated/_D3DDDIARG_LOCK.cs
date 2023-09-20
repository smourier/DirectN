// generated from <Windows SDK Path>\um\d3dumddi.h
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
