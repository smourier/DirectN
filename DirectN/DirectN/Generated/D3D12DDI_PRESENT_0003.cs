// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(1600,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_PRESENT_0003
    {
        public uint hSrcAllocation;
        public uint hDstAllocation;
        public IntPtr hContext;
        public uint BroadcastContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public IntPtr[] BroadcastContext;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public uint[] BroadcastSrcAllocation;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public uint[] BroadcastDstAllocation;
        public bool AddedGpuWork;
        public uint BackBufferMultiplicity;
    }
}
