// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_NODE_CPU_INPUT
    {
        public uint EntrypointIndex;
        public uint NumRecords;
        public IntPtr pRecords;
        public ulong RecordStrideInBytes;
    }
}
