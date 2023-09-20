// generated from <Windows SDK Path>\um\d3d11_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_DECODER_BUFFER_DESC1
    {
        public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;
        public uint DataOffset;
        public uint DataSize;
        public IntPtr pIV;
        public uint IVSize;
        public IntPtr pSubSampleMappingBlock;
        public uint SubSampleMappingCount;
    }
}
