// generated from <Windows SDK Path>\shared\d3d9caps.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DPSHADERCAPS2_0
    {
        public uint Caps;
        public int DynamicFlowControlDepth;
        public int NumTemps;
        public int StaticFlowControlDepth;
        public int NumInstructionSlots;
    }
}
