// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(8582,9)
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
