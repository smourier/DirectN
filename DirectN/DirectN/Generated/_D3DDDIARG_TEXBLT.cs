// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_TEXBLT
    {
        public IntPtr hDstResource;
        public IntPtr hSrcResource;
        public uint CubeMapFace;
        public tagPOINT DstPoint;
        public tagRECT SrcRect;
    }
}
