// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_QUERYCURRENTFENCE
    {
        public uint CurrentFence;
        public uint NodeOrdinal;
        public uint EngineOrdinal;
    }
}
