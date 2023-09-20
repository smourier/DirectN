// generated from <Windows SDK Path>\um\d3d12umddi.h
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
