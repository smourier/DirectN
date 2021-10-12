// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10_1shader.h(150,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_SHADER_DEBUG_OUTPUTVAR
    {
        public uint Var;
        public uint uValueMin;
        public uint uValueMax;
        public int iValueMin;
        public int iValueMax;
        public float fValueMin;
        public float fValueMax;
        public bool bNaNPossible;
        public bool bInfPossible;
    }
}
