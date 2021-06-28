// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(865,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CHECKMULTIPLANEOVERLAYSUPPORT2
    {
        public uint hAdapter;
        public uint hDevice;
        public uint PlaneCount;
        public IntPtr pOverlayPlanes;
        public bool Supported;
        public D3DKMT_CHECK_MULTIPLANE_OVERLAY_SUPPORT_RETURN_INFO ReturnInfo;
    }
}
