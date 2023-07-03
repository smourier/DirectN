// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(6083,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GRAPHICSPOWER_REGISTER_OUTPUT
    {
        public IntPtr DeviceHandle;
        public DEVICE_POWER_STATE InitialGrfxPowerState;
        public IntPtr SetSharedPowerComponentStateCb;
        public IntPtr UnregisterCb;
    }
}
