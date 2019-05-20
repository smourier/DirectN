// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(3414,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DESCRIPTOR_RANGE1
    {
        public D3D12_DESCRIPTOR_RANGE_TYPE RangeType;
        public uint NumDescriptors;
        public uint BaseShaderRegister;
        public uint RegisterSpace;
        public D3D12_DESCRIPTOR_RANGE_FLAGS Flags;
        public uint OffsetInDescriptorsFromTableStart;
    }
}
