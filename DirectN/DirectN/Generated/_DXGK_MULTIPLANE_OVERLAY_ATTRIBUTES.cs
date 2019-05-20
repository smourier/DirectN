// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(369,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_ATTRIBUTES
    {
        public _DXGK_MULTIPLANE_OVERLAY_FLAGS Flags;
        public tagRECT SrcRect;
        public tagRECT DstRect;
        public tagRECT ClipRect;
        public _D3DDDI_ROTATION Rotation;
        public _DXGK_MULTIPLANE_OVERLAY_BLEND Blend;
        public _DXGK_MULTIPLANE_OVERLAY_VIDEO_FRAME_FORMAT VideoFrameFormat;
        public _DXGK_MULTIPLANE_OVERLAY_YCbCr_FLAGS YCbCrFlags;
        public _DXGK_MULTIPLANE_OVERLAY_STEREO_FORMAT StereoFormat;
        public bool StereoLeftViewFrame0;
        public bool StereoBaseViewFrame0;
        public _DXGK_MULTIPLANE_OVERLAY_STEREO_FLIP_MODE StereoFlipMode;
        public _DXGK_MULTIPLANE_OVERLAY_STRETCH_QUALITY StretchQuality;
    }
}
