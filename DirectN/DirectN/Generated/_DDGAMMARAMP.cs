// generated from <Windows SDK Path>\um\ddraw.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDGAMMARAMP
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] red;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] green;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public ushort[] blue;
    }
}
