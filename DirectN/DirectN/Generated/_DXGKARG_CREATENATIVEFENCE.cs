// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATENATIVEFENCE
    {
        public IntPtr hGlobalNativeFence;
        public _D3DDDI_NATIVEFENCE_TYPE Type;
        public ulong CurrentValueSystemProcessGpuVa;
        public ulong MonitoredValueSystemProcessGpuVa;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public byte[] pPrivateDriverData;
        public _DXGKARG_CREATENATIVEFENCE_FLAGS Flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] Reserved;
    }
}
