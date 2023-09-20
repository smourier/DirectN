// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CHECKMULTIPLANEOVERLAYSUPPORT3
    {
        public uint hAdapter;
        public uint hDevice;
        public uint PlaneCount;
        public IntPtr ppOverlayPlanes;
        public uint PostCompositionCount;
        public IntPtr ppPostComposition;
        public bool Supported;
        public D3DKMT_CHECK_MULTIPLANE_OVERLAY_SUPPORT_RETURN_INFO ReturnInfo;
    }
}
