// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CLOSENATIVEFENCE
    {
        public IntPtr hLocalNativeFence;
        public _DXGK_CLOSENATIVEFENCE_FLAGS Flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public byte[] Reserved;
    }
}
