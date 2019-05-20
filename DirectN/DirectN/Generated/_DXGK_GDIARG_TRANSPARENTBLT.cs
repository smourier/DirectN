// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(568,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GDIARG_TRANSPARENTBLT
    {
        public tagRECT SrcRect;
        public tagRECT DstRect;
        public uint SrcAllocationIndex;
        public uint DstAllocationIndex;
        public uint Color;
        public uint NumSubRects;
        public IntPtr pSubRects;
        public _D3DKM_TRANSPARENTBLTFLAGS Flags;
        public uint SrcPitch;
    }
}
