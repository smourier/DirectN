// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(5639,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC
    {
        public uint NodeIndex;
        public D3D12_VIDEO_ENCODER_CODEC Codec;
        public bool IsSupported;
    }
}
