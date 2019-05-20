// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(7720,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_GPU_VIRTUAL_ADDRESS_AND_STRIDE
    {
        public ulong StartAddress;
        public ulong StrideInBytes;
    }
}
