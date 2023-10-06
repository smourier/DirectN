// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_VSYNC_INFO
    {
        public uint LayerIndex;
        public bool Enabled;
        public long PhysicalAddress;
        public _DXGK_MULTIPLANE_OVERLAY_ATTRIBUTES PlaneAttributes;
    }
}
