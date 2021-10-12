// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2785,9)
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
