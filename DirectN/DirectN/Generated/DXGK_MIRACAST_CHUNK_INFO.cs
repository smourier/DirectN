// generated from <Windows SDK Path>\shared\d3dukmdt.h
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
