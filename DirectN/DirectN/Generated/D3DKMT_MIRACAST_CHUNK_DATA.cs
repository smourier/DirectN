﻿// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DKMT_MIRACAST_CHUNK_DATA
    {
        public DXGK_MIRACAST_CHUNK_INFO ChunkInfo;
        public uint PrivateDriverDataSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] PrivateDriverData;
    }
}
