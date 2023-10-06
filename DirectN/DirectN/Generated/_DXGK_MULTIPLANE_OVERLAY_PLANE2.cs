// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_PLANE2
    {
        public uint LayerIndex;
        public bool Enabled;
        public uint AllocationSegment;
        public long AllocationAddress;
        public IntPtr hAllocation;
        public _DXGK_MULTIPLANE_OVERLAY_ATTRIBUTES2 PlaneAttributes;
    }
}
