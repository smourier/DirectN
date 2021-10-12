// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12028,9)
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
