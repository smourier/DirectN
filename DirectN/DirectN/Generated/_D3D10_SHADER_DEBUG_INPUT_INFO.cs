// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10_1shader.h(90,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_DEBUG_INPUT_INFO
    {
        public uint Var;
        public _D3D10_SHADER_DEBUG_REGTYPE InitialRegisterSet;
        public uint InitialBank;
        public uint InitialRegister;
        public uint InitialComponent;
        public uint InitialValue;
    }
}
