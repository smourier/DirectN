// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(2778,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_CHECKMULTIPLANEOVERLAYSUPPORT
    {
        public uint VidPnSourceId;
        public uint NumPlanes;
        public IntPtr pPlanes;
        public bool Supported;
    }
}
