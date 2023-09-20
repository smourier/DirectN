// generated from <Windows SDK Path>\um\d3dnthal.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_DP2SETCLIPPLANE
    {
        public uint dwIndex;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public float[] plane;
    }
}
