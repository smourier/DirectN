// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(1993,9)
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
