// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(920,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_MULTIPLANE_OVERLAY_ATTRIBUTES2
    {
        public uint Flags;
        public tagRECT SrcRect;
        public tagRECT DstRect;
        public tagRECT ClipRect;
        public _D3DDDI_ROTATION Rotation;
        public D3DKMT_MULTIPLANE_OVERLAY_BLEND Blend;
        public uint DirtyRectCount;
        public IntPtr pDirtyRects;
        public D3DKMT_MULTIPLANE_OVERLAY_VIDEO_FRAME_FORMAT VideoFrameFormat;
        public D3DDDI_COLOR_SPACE_TYPE ColorSpace;
        public D3DKMT_MULTIPLANE_OVERLAY_STEREO_FORMAT StereoFormat;
        public bool StereoLeftViewFrame0;
        public bool StereoBaseViewFrame0;
        public _DXGKMT_MULTIPLANE_OVERLAY_STEREO_FLIP_MODE StereoFlipMode;
        public _DXGKMT_MULTIPLANE_OVERLAY_STRETCH_QUALITY StretchQuality;
        public uint Reserved1;
    }
}
