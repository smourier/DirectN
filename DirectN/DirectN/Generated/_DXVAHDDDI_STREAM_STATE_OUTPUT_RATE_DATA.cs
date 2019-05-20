// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(1748,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDDDI_STREAM_STATE_OUTPUT_RATE_DATA
    {
        public bool RepeatFrame;
        public _DXVAHDDDI_OUTPUT_RATE OutputRate;
        public _DXVAHDDDI_RATIONAL CustomRate;
    }
}
