// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11shadertracing.h(223,9)
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
