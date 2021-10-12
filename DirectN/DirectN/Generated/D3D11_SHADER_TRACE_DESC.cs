// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11shadertracing.h(130,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_SHADER_TRACE_DESC
    {
        public D3D11_SHADER_TYPE Type;
        public uint Flags;
        public D3D11_SHADER_TRACE_DESC__union_0 __union_2;
    }
}
