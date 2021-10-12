// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(996,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_MULTIPLANE_OVERLAY_ATTRIBUTES3
    {
        public uint Flags;
        public tagRECT SrcRect;
        public tagRECT DstRect;
        public tagRECT ClipRect;
        public _D3DDDI_ROTATION Rotation;
        public D3DKMT_MULTIPLANE_OVERLAY_BLEND Blend;
        public uint DirtyRectCount;
        public IntPtr pDirtyRects;
        public D3DDDI_COLOR_SPACE_TYPE ColorSpace;
        public _DXGKMT_MULTIPLANE_OVERLAY_STRETCH_QUALITY StretchQuality;
        public uint SDRWhiteLevel;
    }
}
