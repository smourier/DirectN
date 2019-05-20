// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(7062,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_PRESENT_HWQUEUES_0051
    {
        public uint BroadcastQueueCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 65)] 
        public IntPtr[] hHwQueues;
    }
}
