// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
