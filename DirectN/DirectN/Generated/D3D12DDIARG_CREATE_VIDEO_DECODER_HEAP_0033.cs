// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(9376,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_VIDEO_DECODER_HEAP_0033
    {
        public uint NodeMask;
        public D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020 Configuration;
        public uint DecodeWidth;
        public uint DecodeHeight;
        public DXGI_FORMAT Format;
        public DXGI_RATIONAL FrameRate;
        public uint BitRate;
        public uint MaxDecodePictureBufferCount;
    }
}
