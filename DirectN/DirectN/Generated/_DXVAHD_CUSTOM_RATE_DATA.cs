// generated from <Windows SDK Path>\um\dxvahd.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_CUSTOM_RATE_DATA
    {
        public _DXVAHD_RATIONAL CustomRate;
        public uint OutputFrames;
        public bool InputInterlaced;
        public uint InputFramesOrFields;
    }
}
