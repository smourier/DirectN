// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(5757,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CHECKMULTIPLANEOVERLAYSUPPORT3
    {
        public uint PlaneCount;
        public IntPtr ppPlanes;
        public uint PostCompositionCount;
        public IntPtr ppPostComposition;
        public bool Supported;
        public DXGK_CHECK_MULTIPLANE_OVERLAY_SUPPORT_RETURN_INFO ReturnInfo;
    }
}
