// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(5779,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT
    {
        public uint NodeIndex;
        public D3D12_VIDEO_ENCODER_CODEC Codec;
        public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;
        public DXGI_FORMAT Format;
        public bool IsSupported;
    }
}
