// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
