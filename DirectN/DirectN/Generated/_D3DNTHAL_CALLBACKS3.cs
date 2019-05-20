// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dnthal.h(944,9)
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
