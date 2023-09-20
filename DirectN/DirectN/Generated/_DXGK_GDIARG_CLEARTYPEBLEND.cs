// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GDIARG_CLEARTYPEBLEND
    {
        public tagRECT DstRect;
        public uint TmpSurfAllocationIndex;
        public uint GammaSurfAllocationIndex;
        public uint AlphaSurfAllocationIndex;
        public uint DstAllocationIndex;
        public int DstToAlphaOffsetX;
        public int DstToAlphaOffsetY;
        public uint Color;
        public uint Gamma;
        public uint NumSubRects;
        public IntPtr pSubRects;
        public uint AlphaSurfPitch;
        public uint Color2;
    }
}
