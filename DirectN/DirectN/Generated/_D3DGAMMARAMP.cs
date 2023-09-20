// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DGAMMARAMP
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] red;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] green;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] blue;
    }
}
