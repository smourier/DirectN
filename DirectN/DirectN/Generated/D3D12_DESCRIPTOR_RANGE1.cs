// generated from <Windows SDK Path>\um\d3d12.h
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
