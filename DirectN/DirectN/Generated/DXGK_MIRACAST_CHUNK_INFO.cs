// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dukmdt.h(1312,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGK_MIRACAST_CHUNK_INFO
    {
        public _DXGK_MIRACAST_CHUNK_TYPE ChunkType;
        public DXGK_MIRACAST_CHUNK_ID ChunkId;
        public uint ProcessingTime;
        public uint EncodeRate;
    }
}
