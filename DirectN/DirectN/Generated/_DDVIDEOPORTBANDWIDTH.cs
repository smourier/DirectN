// generated from <Windows SDK Path>\um\dvp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDVIDEOPORTBANDWIDTH
    {
        public uint dwSize;
        public uint dwCaps;
        public uint dwOverlay;
        public uint dwColorkey;
        public uint dwYInterpolate;
        public uint dwYInterpAndColorkey;
        public IntPtr dwReserved1;
        public IntPtr dwReserved2;
    }
}
