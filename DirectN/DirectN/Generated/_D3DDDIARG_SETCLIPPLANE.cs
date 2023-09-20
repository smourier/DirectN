// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_SETCLIPPLANE
    {
        public uint Index;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public float[] Plane;
    }
}
