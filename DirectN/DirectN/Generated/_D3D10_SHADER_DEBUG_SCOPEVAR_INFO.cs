// generated from <Windows SDK Path>\um\d3d10_1shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_DEBUG_SCOPEVAR_INFO
    {
        public uint TokenId;
        public _D3D10_SHADER_DEBUG_VARTYPE VarType;
        public _D3D_SHADER_VARIABLE_CLASS Class;
        public uint Rows;
        public uint Columns;
        public uint StructMemberScope;
        public uint uArrayIndices;
        public uint ArrayElements;
        public uint ArrayStrides;
        public uint uVariables;
        public uint uFirstVariable;
    }
}
