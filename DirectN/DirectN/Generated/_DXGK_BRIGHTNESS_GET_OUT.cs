// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGK_BRIGHTNESS_GET_OUT
    {
        public uint CurrentBrightnessMillinits;
        public uint TargetBrightnessMillinits;
    }
}
