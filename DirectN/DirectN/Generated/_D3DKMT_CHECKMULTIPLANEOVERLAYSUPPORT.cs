﻿// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(1002,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CHECKMULTIPLANEOVERLAYSUPPORT
    {
        public uint hDevice;
        public uint PlaneCount;
        public IntPtr pOverlayPlanes;
        public bool Supported;
        public D3DKMT_CHECK_MULTIPLANE_OVERLAY_SUPPORT_RETURN_INFO ReturnInfo;
    }
}
