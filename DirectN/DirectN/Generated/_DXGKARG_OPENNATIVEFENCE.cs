// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_OPENNATIVEFENCE
    {
        public IntPtr hGlobalNativeFence;
        public IntPtr hLocalNativeFence;
        public IntPtr hDevice;
        public ulong CurrentValueGpuVa;
        public ulong MonitoredValueGpuVa;
        public _DXGK_OPENNATIVEFENCE_FLAGS Flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] Reserved;
    }
}
