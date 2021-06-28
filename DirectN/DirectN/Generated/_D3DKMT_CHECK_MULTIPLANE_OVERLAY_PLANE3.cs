// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(929,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CHECK_MULTIPLANE_OVERLAY_PLANE3
    {
        public uint LayerIndex;
        public uint hResource;
        public LUID CompSurfaceLuid;
        public uint VidPnSourceId;
        public IntPtr pPlaneAttributes;
    }
}
