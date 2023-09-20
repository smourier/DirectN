// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_POWER_RUNTIME_STATE
    {
        public ulong TransitionLatency;
        public ulong ResidencyRequirement;
        public uint NominalPower;
    }
}
