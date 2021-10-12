// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(1040,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_MULTIPLANE_OVERLAY_POST_COMPOSITION
    {
        public _D3DKMT_MULTIPLANE_OVERLAY_POST_COMPOSITION_FLAGS Flags;
        public tagRECT SrcRect;
        public tagRECT DstRect;
        public _D3DDDI_ROTATION Rotation;
    }
}
