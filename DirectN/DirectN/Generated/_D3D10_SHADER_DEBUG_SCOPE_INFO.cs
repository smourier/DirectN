// generated from <Windows SDK Path>\um\d3d10_1shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_DEBUG_SCOPE_INFO
    {
        public _D3D10_SHADER_DEBUG_SCOPETYPE ScopeType;
        public uint Name;
        public uint uNameLen;
        public uint uVariables;
        public uint VariableData;
    }
}
