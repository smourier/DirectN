// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10_1shader.h(162,9)
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
        public _D3D10_SHADER_DEBUG_OUTPUTVAR[][] OutputVars;
        public uint IndexReg;
        public uint IndexComp;
    }
}
