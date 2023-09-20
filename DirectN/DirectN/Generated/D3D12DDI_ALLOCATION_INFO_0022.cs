// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_ALLOCATION_INFO_0022
    {
        public uint hAllocation;
        public IntPtr pSystemMem;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public uint VidPnSourceId;
        public D3D12DDI_ALLOCATION_INFO_FLAGS_0022 Flags;
        public ulong GpuVirtualAddress;
        public uint Priority;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public IntPtr[] Reserved;
    }
}
