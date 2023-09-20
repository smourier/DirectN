// generated from <Windows SDK Path>\um\d3d12umddi.h
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
