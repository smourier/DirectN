// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_DXVAHD_SETVIDEOPROCESSSTREAMSTATE
    {
        public IntPtr hVideoProcessor;
        public uint StreamNumber;
        public _DXVAHDDDI_STREAM_STATE State;
        public uint DataSize;
        public IntPtr pData;
    }
}
