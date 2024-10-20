// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGK_DISPLAYMUX_SET_INTERNAL_PANEL_INFO
    {
        public byte Brightness3Supported;
        public _DXGK_BRIGHTNESS_CAPS Brightness3Caps;
        public _DXGK_BRIGHTNESS_GET_NIT_RANGES_OUT Bridgtness3Ranges;
    }
}
