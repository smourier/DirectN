// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10_1shader.h(76,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_DEBUG_VAR_INFO
    {
        public uint TokenId;
        public _D3D_SHADER_VARIABLE_TYPE Type;
        public uint Register;
        public uint Component;
        public uint ScopeVar;
        public uint ScopeVarOffset;
    }
}
