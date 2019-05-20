// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmdt.h(1892,9)
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
