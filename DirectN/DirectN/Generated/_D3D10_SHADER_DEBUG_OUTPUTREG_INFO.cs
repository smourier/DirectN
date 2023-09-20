// generated from <Windows SDK Path>\um\d3d10_1shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_DEBUG_OUTPUTREG_INFO
    {
        public _D3D10_SHADER_DEBUG_REGTYPE OutputRegisterSet;
        public uint OutputReg;
        public uint TempArrayReg;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] OutputComponents;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public _D3D10_SHADER_DEBUG_OUTPUTVAR[] OutputVars;
        public uint IndexReg;
        public uint IndexComp;
    }
}
