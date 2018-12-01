// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(3637,9)
using System;
using System.Runtime.InteropServices;
using D3D12_RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DISCARD_REGION
    {
        public uint NumRects;
        public IntPtr pRects;
        public uint FirstSubresource;
        public uint NumSubresources;
    }
}
