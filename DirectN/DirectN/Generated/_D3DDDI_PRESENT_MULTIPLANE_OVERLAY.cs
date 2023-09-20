// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_PRESENT_MULTIPLANE_OVERLAY
    {
        public uint LayerIndex;
        public bool Enabled;
        public IntPtr hResource;
        public uint SubResourceIndex;
        public _D3DDDI_MULTIPLANE_OVERLAY_ATTRIBUTES PlaneAttributes;
    }
}
