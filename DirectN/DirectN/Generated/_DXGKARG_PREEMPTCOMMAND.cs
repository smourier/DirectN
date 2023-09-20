// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_PREEMPTCOMMAND
    {
        public uint PreemptionFenceId;
        public uint NodeOrdinal;
        public uint EngineOrdinal;
        public _DXGK_PREEMPTCOMMANDFLAGS Flags;
    }
}
