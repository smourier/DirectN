// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(3161,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_GEOMETRY_SHADER_WITH_STREAM_OUTPUT_0010
    {
        public D3D12DDIARG_CREATE_SHADER_0010 CreateShader;
        public IntPtr pOutputStreamDecl;
        public uint NumEntries;
        public IntPtr BufferStridesInBytes;
        public uint NumStrides;
        public uint RasterizedStream;
    }
}
