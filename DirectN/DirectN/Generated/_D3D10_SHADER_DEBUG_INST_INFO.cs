// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10_1shader.h(183,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_DEBUG_INST_INFO
    {
        public uint Id;
        public uint Opcode;
        public uint uOutputs;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public _D3D10_SHADER_DEBUG_OUTPUTREG_INFO[] pOutputs;
        public uint TokenId;
        public uint NestingLevel;
        public uint Scopes;
        public uint ScopeInfo;
        public uint AccessedVars;
        public uint AccessedVarsInfo;
    }
}
