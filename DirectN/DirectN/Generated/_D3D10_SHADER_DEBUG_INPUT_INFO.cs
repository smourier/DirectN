// generated from <Windows SDK Path>\um\d3d10_1shader.h
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
