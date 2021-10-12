// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(4387,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_TEX1D_ARRAY_DSV
    {
        public uint MipSlice;
        public uint FirstArraySlice;
        public uint ArraySize;
    }
}
