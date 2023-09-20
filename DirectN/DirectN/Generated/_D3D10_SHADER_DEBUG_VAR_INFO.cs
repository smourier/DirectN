// generated from <Windows SDK Path>\um\d3d10_1shader.h
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
