// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(6051,9)
using System;
using System.Runtime.InteropServices;
using PDXGK_FSTATE_NOTIFICATION = System.IntPtr;
using PDXGK_INITIAL_COMPONENT_STATE = System.IntPtr;
using PDXGK_POWER_NOTIFICATION = System.IntPtr;
using PDXGK_REMOVAL_NOTIFICATION = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GRAPHICSPOWER_REGISTER_INPUT_V_1_2
    {
        public uint Version;
        public IntPtr PrivateHandle;
        public IntPtr PowerNotificationCb;
        public IntPtr RemovalNotificationCb;
        public IntPtr FStateNotificationCb;
        public IntPtr InitialComponentStateCb;
    }
}
