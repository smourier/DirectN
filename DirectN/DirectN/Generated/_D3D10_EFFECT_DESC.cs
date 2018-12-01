// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10effect.h(1285,9)
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
