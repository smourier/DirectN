// generated from <Windows SDK Path>\um\d3dnthal.h
using System;
using System.Runtime.InteropServices;
using LPD3DNTHAL_CLEAR2CB = System.IntPtr;
using LPD3DNTHAL_DRAWPRIMITIVES2CB = System.IntPtr;
using LPD3DNTHAL_VALIDATETEXTURESTAGESTATECB = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_CALLBACKS3
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr Clear2;
        public IntPtr lpvReserved;
        public IntPtr ValidateTextureStageState;
        public IntPtr DrawPrimitives2;
    }
}
