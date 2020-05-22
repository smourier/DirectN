// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11_4.h(3117,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM
    {
        public D3D11_VIDEO_DECODER_DESC DecoderDesc;
        public D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAGS Components;
        public uint BinCount;
        public uint CounterBitDepth;
    }
}
