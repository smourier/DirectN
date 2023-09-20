// generated from <Windows SDK Path>\um\d3dumddi.h
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
