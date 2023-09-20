// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDI_CHECK_MULTIPLANE_OVERLAY_SUPPORT_PLANE_INFO
    {
        public IntPtr hResource;
        public uint SubResourceIndex;
        public _D3DDDI_MULTIPLANE_OVERLAY_ATTRIBUTES PlaneAttributes;
    }
}
