// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(3549,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_ROOT_DESCRIPTOR1
    {
        public uint ShaderRegister;
        public uint RegisterSpace;
        public D3D12_ROOT_DESCRIPTOR_FLAGS Flags;
    }
}
