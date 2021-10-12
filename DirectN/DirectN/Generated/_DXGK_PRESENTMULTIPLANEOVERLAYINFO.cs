// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(228,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PRESENTMULTIPLANEOVERLAYINFO
    {
        public uint VidPnSourceId;
        public uint PlaneListCount;
        public IntPtr pPlaneList;
    }
}
