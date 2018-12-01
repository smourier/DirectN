﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\dxgi1_6.h(100,9)
using System;
using System.Runtime.InteropServices;

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
        public ulong DedicatedVideoMemory;
        public ulong DedicatedSystemMemory;
        public ulong SharedSystemMemory;
        public _LUID AdapterLuid;
        public DXGI_ADAPTER_FLAG3 Flags;
        public DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;
        public DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;
    }
}