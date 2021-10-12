// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10_1shader.h(140,9)
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
