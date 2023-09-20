// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_MULTIPLANE_OVERLAY2
    {
        public uint LayerIndex;
        public bool Enabled;
        public uint hAllocation;
        public _D3DKMT_MULTIPLANE_OVERLAY_ATTRIBUTES2 PlaneAttributes;
    }
}
