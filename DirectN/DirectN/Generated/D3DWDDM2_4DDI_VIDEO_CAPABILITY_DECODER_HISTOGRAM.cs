// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(4572,9)
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
