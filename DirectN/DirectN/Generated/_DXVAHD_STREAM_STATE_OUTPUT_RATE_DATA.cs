// generated from <Windows SDK Path>\um\dxvahd.h
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
