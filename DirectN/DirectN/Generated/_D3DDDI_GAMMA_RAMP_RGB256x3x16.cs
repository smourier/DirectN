// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_GAMMA_RAMP_RGB256x3x16
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] Red;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] Green;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] Blue;
    }
}
