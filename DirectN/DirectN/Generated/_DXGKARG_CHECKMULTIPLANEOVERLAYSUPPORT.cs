// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(5705,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CHECKMULTIPLANEOVERLAYSUPPORT
    {
        public uint PlaneCount;
        public IntPtr pPlanes;
        public bool Supported;
        public DXGK_CHECK_MULTIPLANE_OVERLAY_SUPPORT_RETURN_INFO ReturnInfo;
    }
}
