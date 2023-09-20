// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_ARG_SET_GAMMA_CONTROL
    {
        public ulong hDevice;
        public DXGI_GAMMA_CONTROL GammaControl;
    }
}
