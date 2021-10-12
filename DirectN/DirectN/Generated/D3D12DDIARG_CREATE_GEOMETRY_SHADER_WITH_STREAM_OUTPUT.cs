// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(2029,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_GEOMETRY_SHADER_WITH_STREAM_OUTPUT
    {
        public IntPtr pShaderCode;
        public D3D12DDI_HROOTSIGNATURE hRootSignature;
        public IntPtr pOutputStreamDecl;
        public uint NumEntries;
        public IntPtr BufferStridesInBytes;
        public uint NumStrides;
        public uint RasterizedStream;
    }
}
