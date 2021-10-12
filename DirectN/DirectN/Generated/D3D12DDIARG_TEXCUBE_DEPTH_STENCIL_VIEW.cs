// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1226,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_TEXCUBE_DEPTH_STENCIL_VIEW
    {
        public uint MipSlice;
        public uint FirstArraySlice;
        public uint ArraySize;
    }
}
