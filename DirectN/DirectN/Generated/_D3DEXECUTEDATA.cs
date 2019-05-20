// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dtypes.h(1904,9)
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
