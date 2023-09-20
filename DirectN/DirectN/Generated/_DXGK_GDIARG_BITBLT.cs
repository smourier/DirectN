// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GDIARG_BITBLT
    {
        public tagRECT SrcRect;
        public tagRECT DstRect;
        public uint SrcAllocationIndex;
        public uint DstAllocationIndex;
        public uint NumSubRects;
        public IntPtr pSubRects;
        public ushort Rop;
        public ushort Rop3;
        public uint SrcPitch;
        public uint DstPitch;
    }
}
