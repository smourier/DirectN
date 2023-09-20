// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_COMMAND_SIGNATURE_0001
    {
        public uint ByteStride;
        public uint NumArgumentDescs;
        public IntPtr pArgumentDescs;
        public D3D12DDI_HROOTSIGNATURE hRootSignature;
        public uint NodeMask;
    }
}
