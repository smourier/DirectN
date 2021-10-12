// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(774,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_VSYNC_INFO2
    {
        public uint LayerIndex;
        public ulong PresentId;
        public _DXGKCB_NOTIFY_MPO_VSYNC_FLAGS Flags;
    }
}
