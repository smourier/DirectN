// generated from <Windows SDK Path>\um\dxvahd.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_STREAM_STATE_ASPECT_RATIO_DATA
    {
        public bool Enable;
        public _DXVAHD_RATIONAL SourceAspectRatio;
        public _DXVAHD_RATIONAL DestinationAspectRatio;
    }
}
