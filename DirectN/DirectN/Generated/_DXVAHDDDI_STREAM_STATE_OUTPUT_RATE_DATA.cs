// generated from <Windows SDK Path>\um\d3dumddi.h
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
