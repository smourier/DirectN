// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d10_1shader.h(219,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_DEBUG_INFO
    {
        public uint Size;
        public uint Creator;
        public uint EntrypointName;
        public uint ShaderTarget;
        public uint CompileFlags;
        public uint Files;
        public uint FileInfo;
        public uint Instructions;
        public uint InstructionInfo;
        public uint Variables;
        public uint VariableInfo;
        public uint InputVariables;
        public uint InputVariableInfo;
        public uint Tokens;
        public uint TokenInfo;
        public uint Scopes;
        public uint ScopeInfo;
        public uint ScopeVariables;
        public uint ScopeVariableInfo;
        public uint UintOffset;
        public uint StringOffset;
    }
}
