// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(8808,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_INHERITED_TIMING_INFO__union_1__struct_0
    {
        public _DXGK_GLITCH_CAUSE GlitchCause;
        public _DXGK_GLITCH_EFFECT GlitchEffect;
        public _DXGK_GLITCH_DURATION GlitchDuration;
        public byte Reserved;
    }
}
