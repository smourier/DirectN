// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(3819,9)
using System;
using System.Runtime.InteropServices;

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
