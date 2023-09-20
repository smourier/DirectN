// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_DECODER_HEAP_SIZE_DATA_0072
    {
        public uint NodeMask;
        public D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020 Configuration;
        public uint DecodeWidth;
        public uint DecodeHeight;
        public DXGI_FORMAT Format;
        public DXGI_RATIONAL FrameRate;
        public uint BitRate;
        public uint MaxDecodePictureBufferCount;
        public bool Protected;
        public ulong MemoryPoolL0Size;
        public ulong MemoryPoolL1Size;
    }
}
