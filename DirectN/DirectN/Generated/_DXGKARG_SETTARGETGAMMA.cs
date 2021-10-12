// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(8635,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETTARGETGAMMA
    {
        public uint TargetId;
        public _D3DKMDT_GAMMA_RAMP GammaRamp;
    }
}
