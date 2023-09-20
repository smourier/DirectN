// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_OPENRESOURCE
    {
        public uint NumAllocations;
        public _D3DDDIARG_OPENRESOURCE__union_0 __union_1;
        public uint hKMResource;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public IntPtr hResource;
        public _D3DDDI_ROTATION Rotation;
        public _D3DDDI_OPENRESOURCEFLAGS Flags;
    }
}
