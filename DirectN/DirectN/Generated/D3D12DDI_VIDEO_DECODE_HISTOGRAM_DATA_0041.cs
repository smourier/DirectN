// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(11216,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_DECODE_HISTOGRAM_DATA_0041
    {
        public uint NodeIndex;
        public Guid DecodeProfile;
        public uint Width;
        public uint Height;
        public DXGI_FORMAT DecodeFormat;
        public D3D12DDI_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS_0041 Components;
        public uint BinCount;
        public uint CounterBitDepth;
    }
}
