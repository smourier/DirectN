// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1
    {
        public uint ConstantQP_FullIntracodedFrame;
        public uint ConstantQP_InterPredictedFrame_PrevRefOnly;
        public uint ConstantQP_InterPredictedFrame_BiDirectionalRef;
        public uint QualityVsSpeed;
    }
}
