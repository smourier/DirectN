// generated from <Windows SDK Path>\um\d3d10effect.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D10_EFFECT_DESC
    {
        public bool IsChildEffect;
        public uint ConstantBuffers;
        public uint SharedConstantBuffers;
        public uint GlobalVariables;
        public uint SharedGlobalVariables;
        public uint Techniques;
    }
}
