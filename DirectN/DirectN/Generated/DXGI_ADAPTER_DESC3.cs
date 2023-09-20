// generated from <Windows SDK Path>\shared\dxgi1_6.h
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct DXGI_ADAPTER_DESC3
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string Description;
        public uint VendorId;
        public uint DeviceId;
        public uint SubSysId;
        public uint Revision;
        public IntPtr DedicatedVideoMemory;
        public IntPtr DedicatedSystemMemory;
        public IntPtr SharedSystemMemory;
        public LUID AdapterLuid;
        public DXGI_ADAPTER_FLAG3 Flags;
        public DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;
        public DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;
    }
}
