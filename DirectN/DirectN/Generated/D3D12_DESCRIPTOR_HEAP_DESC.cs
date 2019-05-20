// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(3275,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DESCRIPTOR_HEAP_DESC
    {
        public D3D12_DESCRIPTOR_HEAP_TYPE Type;
        public uint NumDescriptors;
        public D3D12_DESCRIPTOR_HEAP_FLAGS Flags;
        public uint NodeMask;
    }
}
