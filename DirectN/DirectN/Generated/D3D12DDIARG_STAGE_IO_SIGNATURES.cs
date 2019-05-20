// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(2043,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_STAGE_IO_SIGNATURES
    {
        public D3D12DDIARG_STAGE_IO_SIGNATURES__union_0 __union_0;
        public uint NumInputSignatureEntries;
        public D3D12DDIARG_STAGE_IO_SIGNATURES__union_1 __union_2;
        public uint NumOutputSignatureEntries;
    }
}
