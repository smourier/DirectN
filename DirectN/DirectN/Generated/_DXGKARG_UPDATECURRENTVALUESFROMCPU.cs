// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_UPDATECURRENTVALUESFROMCPU
    {
        public IntPtr NativeFenceArray;
        public IntPtr UpdatedValueArray;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object CurrentValueKernelCpuVa;
        public uint NumFences;
        public _DXGK_UPDATECURRENTVALUESFROMCPU_FLAGS Flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)] 
        public byte[] Reserved;
    }
}
