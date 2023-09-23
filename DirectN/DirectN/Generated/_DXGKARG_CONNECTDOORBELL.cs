// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CONNECTDOORBELL
    {
        public IntPtr hDoorbell;
        public _DXGKARG_CONNECTDOORBELL_FLAGS Flags;
        public IntPtr KernelCpuVirtualAddress;
        public IntPtr SecondaryKernelCpuVirtualAddress;
        public _D3DDDI_DOORBELLSTATUS Status;
    }
}
