// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_ARG_GET_GAMMA_CONTROL_CAPS
    {
        public ulong hDevice;
        public IntPtr pGammaCapabilities;
    }
}
