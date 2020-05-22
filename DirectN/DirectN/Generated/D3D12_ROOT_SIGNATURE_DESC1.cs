// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(3568,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_ROOT_SIGNATURE_DESC1
    {
        public uint NumParameters;
        public IntPtr pParameters;
        public uint NumStaticSamplers;
        public IntPtr pStaticSamplers;
        public D3D12_ROOT_SIGNATURE_FLAGS Flags;
    }
}
