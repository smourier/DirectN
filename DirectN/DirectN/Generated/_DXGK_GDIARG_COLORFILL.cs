// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GDIARG_COLORFILL
    {
        public tagRECT DstRect;
        public uint DstAllocationIndex;
        public uint NumSubRects;
        public IntPtr pSubRects;
        public uint Color;
        public ushort Rop;
        public ushort Rop3;
    }
}
