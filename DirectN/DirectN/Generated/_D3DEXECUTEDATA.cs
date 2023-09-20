// generated from <Windows SDK Path>\um\d3dtypes.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DEXECUTEDATA
    {
        public uint dwSize;
        public uint dwVertexOffset;
        public uint dwVertexCount;
        public uint dwInstructionOffset;
        public uint dwInstructionLength;
        public uint dwHVertexOffset;
        public _D3DSTATUS dsStatus;
    }
}
