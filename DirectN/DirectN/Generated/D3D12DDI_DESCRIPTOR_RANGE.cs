// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_DESCRIPTOR_RANGE
    {
        public D3D12DDI_DESCRIPTOR_RANGE_TYPE RangeType;
        public uint NumDescriptors;
        public uint BaseShaderRegister;
        public uint RegisterSpace;
        public uint OffsetInDescriptorsFromTableStart;
    }
}
