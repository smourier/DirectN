// generated from <Windows SDK Path>\um\d3dhal.h
using System;
using System.Runtime.InteropServices;
using LPD3DHAL_CLEAR2CB = System.IntPtr;
using LPD3DHAL_DRAWPRIMITIVES2CB = System.IntPtr;
using LPD3DHAL_VALIDATETEXTURESTAGESTATECB = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_CALLBACKS3
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr Clear2;
        public IntPtr lpvReserved;
        public IntPtr ValidateTextureStageState;
        public IntPtr DrawPrimitives2;
    }
}
