// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(5306,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_ATTRIBUTES3
    {
        public _DXGK_MULTIPLANE_OVERLAY_FLAGS Flags;
        public tagRECT SrcRect;
        public tagRECT DstRect;
        public tagRECT ClipRect;
        public _D3DDDI_ROTATION Rotation;
        public _DXGK_MULTIPLANE_OVERLAY_BLEND Blend;
        public D3DDDI_COLOR_SPACE_TYPE ColorSpaceType;
        public _DXGK_MULTIPLANE_OVERLAY_STRETCH_QUALITY StretchQuality;
        public uint SDRWhiteLevel;
        public uint DirtyRectCnt;
        public IntPtr pDirtyRects;
    }
}
