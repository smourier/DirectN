// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2771,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDI_CHECK_MULTIPLANE_OVERLAY_SUPPORT_PLANE_INFO
    {
        public IntPtr hResource;
        public uint SubResourceIndex;
        public _D3DDDI_MULTIPLANE_OVERLAY_ATTRIBUTES PlaneAttributes;
    }
}
