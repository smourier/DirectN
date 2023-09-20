// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_COMMAND_SIGNATURE_DESC
    {
        public uint ByteStride;
        public uint NumArgumentDescs;
        public IntPtr pArgumentDescs;
        public uint NodeMask;
    }
}
