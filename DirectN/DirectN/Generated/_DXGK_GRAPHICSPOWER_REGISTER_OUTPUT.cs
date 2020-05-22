// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(4921,9)
using System;
using System.Runtime.InteropServices;
using PDXGK_GRAPHICSPOWER_UNREGISTER = System.IntPtr;
using PDXGK_SET_SHARED_POWER_COMPONENT_STATE = System.IntPtr;

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
