// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
