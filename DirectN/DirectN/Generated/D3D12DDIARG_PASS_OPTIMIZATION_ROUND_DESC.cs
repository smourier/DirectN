// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(13868,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_PASS_OPTIMIZATION_ROUND_DESC
    {
        public uint MinimumNumberOfPassesPerRound;
        public bool UsefulToRunAdditionalPassesPerRound;
    }
}
