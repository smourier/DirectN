// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(6192,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_DESC
    {
        public uint NodeMask;
        public D3D12_VIDEO_ENCODER_FLAGS Flags;
        public D3D12_VIDEO_ENCODER_CODEC EncodeCodec;
        public D3D12_VIDEO_ENCODER_PROFILE_DESC EncodeProfile;
        public DXGI_FORMAT InputFormat;
        public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;
        public D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE MaxMotionEstimationPrecision;
    }
}
