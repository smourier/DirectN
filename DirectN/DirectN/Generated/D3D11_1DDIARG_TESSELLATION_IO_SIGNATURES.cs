// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDIARG_TESSELLATION_IO_SIGNATURES
    {
        public D3D11_1DDIARG_TESSELLATION_IO_SIGNATURES__union_0 __union_0;
        public uint NumInputSignatureEntries;
        public D3D11_1DDIARG_TESSELLATION_IO_SIGNATURES__union_1 __union_2;
        public uint NumOutputSignatureEntries;
        public D3D11_1DDIARG_TESSELLATION_IO_SIGNATURES__union_2 __union_4;
        public uint NumPatchConstantSignatureEntries;
    }
}
