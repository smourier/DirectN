// generated from <Windows SDK Path>\um\d3d12umddi.h
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
