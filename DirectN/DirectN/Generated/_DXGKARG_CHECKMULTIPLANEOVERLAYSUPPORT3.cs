// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
