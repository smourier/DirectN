// generated from <Windows SDK Path>\um\d3d11shadertracing.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_TRACE_REGISTER
    {
        public D3D11_TRACE_REGISTER_TYPE RegType;
        public D3D11_TRACE_REGISTER__union_0 __union_1;
        public byte OperandIndex;
        public byte Flags;
    }
}
