// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_CHECK_MULTIPLANE_OVERLAY_SUPPORT_PLANE
    {
        public IntPtr hAllocation;
        public uint VidPnSourceId;
        public _DXGK_MULTIPLANE_OVERLAY_ATTRIBUTES PlaneAttributes;
    }
}
