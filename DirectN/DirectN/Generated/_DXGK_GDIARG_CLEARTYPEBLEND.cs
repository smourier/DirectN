// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(588,9)
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
