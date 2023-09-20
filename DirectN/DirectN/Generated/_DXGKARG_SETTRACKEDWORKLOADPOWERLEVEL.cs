// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETTRACKEDWORKLOADPOWERLEVEL
    {
        public uint PowerLevel;
        public uint EffectivePowerLevel;
        public _DXGK_TRACKEDWORKLOAD_STATE_FLAGS Flags;
    }
}
