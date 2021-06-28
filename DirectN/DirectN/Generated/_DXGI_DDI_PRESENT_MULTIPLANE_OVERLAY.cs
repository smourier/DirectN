// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxgiddi.h(462,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_PRESENT_MULTIPLANE_OVERLAY
    {
        public uint LayerIndex;
        public bool Enabled;
        public ulong hResource;
        public uint SubResourceIndex;
        public DXGI_DDI_MULTIPLANE_OVERLAY_ATTRIBUTES PlaneAttributes;
    }
}
