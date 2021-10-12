// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(548,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GDIARG_ALPHABLEND
    {
        public tagRECT SrcRect;
        public tagRECT DstRect;
        public uint SrcAllocationIndex;
        public uint DstAllocationIndex;
        public uint NumSubRects;
        public IntPtr pSubRects;
        public byte SourceConstantAlpha;
        public byte SourceHasAlpha;
        public uint SrcPitch;
    }
}
