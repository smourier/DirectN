// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(3056,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_TEX3D_RTV
    {
        public uint MipSlice;
        public uint FirstWSlice;
        public uint WSize;
    }
}
