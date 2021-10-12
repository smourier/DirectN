// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12201,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_RATE_CONTROL_CQP_0080
    {
        public uint ConstantQP_FullIntracodedFrame;
        public uint ConstantQP_InterPredictedFrame_PrevRefOnly;
        public uint ConstantQP_InterPredictedFrame_BiDirectionalRef;
    }
}
