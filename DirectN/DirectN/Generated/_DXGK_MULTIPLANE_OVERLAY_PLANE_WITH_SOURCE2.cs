// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_PLANE_WITH_SOURCE2
    {
        public IntPtr hAllocation;
        public uint VidPnSourceId;
        public uint LayerIndex;
        public _DXGK_MULTIPLANE_OVERLAY_ATTRIBUTES3 PlaneAttributes;
    }
}
