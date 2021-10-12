// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(8372,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_CONNECTION_USB4_INFO
    {
        public uint Dpcd_DP_IN_Adapter_Number;
        public uint Dpcd_USB4_Driver_ID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public byte[] Dpcd_USB4_ROUTER_TOPOLOGY_ID;
    }
}
