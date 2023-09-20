// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DKMT_MULTIPLANE_OVERLAY
    {
        public uint LayerIndex;
        public bool Enabled;
        public uint hAllocation;
        public D3DKMT_MULTIPLANE_OVERLAY_ATTRIBUTES PlaneAttributes;
    }
}
