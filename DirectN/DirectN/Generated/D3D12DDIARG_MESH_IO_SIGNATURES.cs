// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(2142,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_MESH_IO_SIGNATURES
    {
        public IntPtr pPrimitiveOutputSignature;
        public uint NumPrimitiveOutputSignatureEntries;
        public IntPtr pVertexOutputSignature;
        public uint NumVertexOutputSignatureEntries;
    }
}
