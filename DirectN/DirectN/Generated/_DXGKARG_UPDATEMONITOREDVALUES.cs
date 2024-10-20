// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_UPDATEMONITOREDVALUES
    {
        public IntPtr NativeFenceArray;
        public IntPtr UpdatedValueArray;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object MonitoredValueKernelCpuVa;
        public uint NumFences;
        public _DXGKARG_UPDATEMONITOREDVALUES_FLAGS Flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)] 
        public byte[] Reserved;
    }
}
