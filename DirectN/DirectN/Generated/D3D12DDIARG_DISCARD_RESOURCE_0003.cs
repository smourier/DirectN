// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(1991,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_DISCARD_RESOURCE_0003
    {
        public uint NumRects;
        public IntPtr pRects;
        public uint FirstSubresource;
        public uint NumSubresources;
    }
}
