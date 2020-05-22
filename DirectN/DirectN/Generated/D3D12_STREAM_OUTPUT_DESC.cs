// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(1876,9)
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
