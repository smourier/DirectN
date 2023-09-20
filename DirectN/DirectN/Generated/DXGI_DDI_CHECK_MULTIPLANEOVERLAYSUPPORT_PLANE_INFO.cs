// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_CHECK_MULTIPLANEOVERLAYSUPPORT_PLANE_INFO
    {
        public ulong hResource;
        public uint SubResourceIndex;
        public DXGI_DDI_MULTIPLANE_OVERLAY_ATTRIBUTES PlaneAttributes;
    }
}
