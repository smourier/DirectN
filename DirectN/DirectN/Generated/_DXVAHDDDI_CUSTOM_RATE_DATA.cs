// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2590,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDDDI_CUSTOM_RATE_DATA
    {
        public _DXVAHDDDI_RATIONAL CustomRate;
        public uint OutputFrames;
        public bool InputInterlaced;
        public uint InputFramesOrFields;
    }
}
