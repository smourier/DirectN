// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SET_TIMING_PATH_INFO__union_3__struct_0
    {
        public _DXGK_GLITCH_CAUSE GlitchCause;
        public _DXGK_GLITCH_EFFECT GlitchEffect;
        public _DXGK_GLITCH_DURATION GlitchDuration;
        public byte Reserved;
    }
}
