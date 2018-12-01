// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(109,9)
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
