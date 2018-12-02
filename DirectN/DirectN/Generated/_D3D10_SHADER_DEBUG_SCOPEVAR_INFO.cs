// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10_1shader.h(107,9)
using System;
using System.Runtime.InteropServices;
using D3D10_SHADER_VARIABLE_CLASS = DirectN._D3D_SHADER_VARIABLE_CLASS;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_DEBUG_SCOPEVAR_INFO
    {
        public uint TokenId;
        public _D3D10_SHADER_DEBUG_VARTYPE VarType;
        public D3D10_SHADER_VARIABLE_CLASS Class;
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
