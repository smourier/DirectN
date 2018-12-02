// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10_1shader.h(76,9)
using System;
using System.Runtime.InteropServices;
using D3D10_SHADER_VARIABLE_TYPE = DirectN._D3D_SHADER_VARIABLE_TYPE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_DEBUG_VAR_INFO
    {
        public uint TokenId;
        public D3D10_SHADER_VARIABLE_TYPE Type;
        public uint Register;
        public uint Component;
        public uint ScopeVar;
        public uint ScopeVarOffset;
    }
}
