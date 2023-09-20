// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_POST_COMPOSITION
    {
        public _DXGK_MULTIPLANE_OVERLAY_POST_COMPOSITION_FLAGS Flags;
        public tagRECT SrcRect;
        public tagRECT DstRect;
        public _D3DDDI_ROTATION Rotation;
    }
}
