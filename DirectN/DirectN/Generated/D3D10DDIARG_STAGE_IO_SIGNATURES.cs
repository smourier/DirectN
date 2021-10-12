// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(745,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDIARG_STAGE_IO_SIGNATURES
    {
        public IntPtr pInputSignature;
        public uint NumInputSignatureEntries;
        public IntPtr pOutputSignature;
        public uint NumOutputSignatureEntries;
    }
}
