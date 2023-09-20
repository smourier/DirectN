// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_4DDI_VIDEO_CAPABILITY_DECODER_HISTOGRAM
    {
        public D3D11_1DDI_VIDEO_DECODER_DESC DecoderDesc;
        public D3DWDDM2_4DDI_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAGS Components;
        public uint BinCount;
        public uint CounterBitDepth;
    }
}
