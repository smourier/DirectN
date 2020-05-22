// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxvahd.h(406,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_STREAM_STATE_OUTPUT_RATE_DATA
    {
        public bool RepeatFrame;
        public _DXVAHD_OUTPUT_RATE OutputRate;
        public _DXVAHD_RATIONAL CustomRate;
    }
}
