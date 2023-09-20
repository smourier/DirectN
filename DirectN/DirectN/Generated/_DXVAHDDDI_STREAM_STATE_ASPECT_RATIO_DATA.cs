// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDDDI_STREAM_STATE_ASPECT_RATIO_DATA
    {
        public bool Enable;
        public _DXVAHDDDI_RATIONAL SourceAspectRatio;
        public _DXVAHDDDI_RATIONAL DestinationAspectRatio;
    }
}
