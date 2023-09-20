// generated from <Windows SDK Path>\um\d3d10_1shader.h
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
