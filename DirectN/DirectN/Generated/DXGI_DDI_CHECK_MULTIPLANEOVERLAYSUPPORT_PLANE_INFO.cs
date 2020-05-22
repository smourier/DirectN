// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxgiddi.h(446,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_CHECK_MULTIPLANEOVERLAYSUPPORT_PLANE_INFO
    {
        public ulong hResource;
        public uint SubResourceIndex;
        public DXGI_DDI_MULTIPLANE_OVERLAY_ATTRIBUTES PlaneAttributes;
    }
}
