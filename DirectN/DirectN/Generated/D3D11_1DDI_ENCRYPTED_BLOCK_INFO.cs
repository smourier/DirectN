// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_ENCRYPTED_BLOCK_INFO
    {
        public uint NumEncryptedBytesAtBeginning;
        public uint NumBytesInSkipPattern;
        public uint NumBytesInEncryptPattern;
    }
}
