// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11DDIARG_TESSELLATION_IO_SIGNATURES
    {
        public IntPtr pInputSignature;
        public uint NumInputSignatureEntries;
        public IntPtr pOutputSignature;
        public uint NumOutputSignatureEntries;
        public IntPtr pPatchConstantSignature;
        public uint NumPatchConstantSignatureEntries;
    }
}
