// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_FENCE_RESIDENCY_INFO
    {
        public IntPtr hGlobalNativeFence;
        public _D3DGPU_PHYSICAL_ADDRESS CurrentValuePhysicalAddress;
        public _D3DGPU_PHYSICAL_ADDRESS MonitoredValuePhysicalAddress;
        public IntPtr CurrentValueKernelCpuVa;
        public IntPtr MonitoredValueKernelCpuVa;
    }
}
