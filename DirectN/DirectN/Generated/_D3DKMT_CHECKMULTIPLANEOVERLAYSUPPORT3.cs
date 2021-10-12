// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(1054,9)
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
