// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11shadertracing.h(252,9)
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
