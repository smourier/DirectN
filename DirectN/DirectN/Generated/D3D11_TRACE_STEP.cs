// generated from <Windows SDK Path>\um\d3d11shadertracing.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_TRACE_STEP
    {
        public uint ID;
        public bool InstructionActive;
        public byte NumRegistersWritten;
        public byte NumRegistersRead;
        public ushort MiscOperations;
        public uint OpcodeType;
        public ulong CurrentGlobalCycle;
    }
}
