// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(887,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DKMT_CHECK_MULTIPLANE_OVERLAY_PLANE
    {
        public uint hResource;
        public LUID CompSurfaceLuid;
        public uint VidPnSourceId;
        public D3DKMT_MULTIPLANE_OVERLAY_ATTRIBUTES PlaneAttributes;
    }
}
