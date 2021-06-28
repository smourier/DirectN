// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxgiddi.h(104,9)
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
