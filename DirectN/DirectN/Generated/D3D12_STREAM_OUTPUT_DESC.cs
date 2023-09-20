// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_STREAM_OUTPUT_DESC
    {
        public IntPtr pSODeclaration;
        public uint NumEntries;
        public IntPtr pBufferStrides;
        public uint NumStrides;
        public uint RasterizedStream;
    }
}
