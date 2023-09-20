// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_PRESENT_MULTIPLANE_OVERLAY1
    {
        public uint LayerIndex;
        public bool Enabled;
        public ulong hResource;
        public uint SubResourceIndex;
        public DXGI_DDI_MULTIPLANE_OVERLAY_ATTRIBUTES1 PlaneAttributes;
    }
}
