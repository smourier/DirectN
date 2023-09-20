// generated from <Windows SDK Path>\um\d3d11_4.h
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
