// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(875,9)
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
