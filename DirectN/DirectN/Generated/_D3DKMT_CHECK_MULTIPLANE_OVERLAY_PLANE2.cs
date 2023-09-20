// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CHECK_MULTIPLANE_OVERLAY_PLANE2
    {
        public uint LayerIndex;
        public uint hResource;
        public LUID CompSurfaceLuid;
        public uint VidPnSourceId;
        public _D3DKMT_MULTIPLANE_OVERLAY_ATTRIBUTES2 PlaneAttributes;
    }
}
