// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGK_BACKLIGHT_INFO
    {
        public ushort BacklightUsersetting;
        public ushort BacklightEffective;
        public _D3DDDI_GAMMA_RAMP_RGB256x3x16 GammaRamp;
    }
}
