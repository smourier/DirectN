// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(7155,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_PRESENT_0051
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 65)] 
        public uint[] BroadcastSrcAllocation;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 65)] 
        public uint[] BroadcastDstAllocation;
        public bool AddedGpuWork;
        public uint BackBufferMultiplicity;
        public bool SyncIntervalOverrideValid;
        public DXGI_DDI_FLIP_INTERVAL_TYPE SyncIntervalOverride;
    }
}
