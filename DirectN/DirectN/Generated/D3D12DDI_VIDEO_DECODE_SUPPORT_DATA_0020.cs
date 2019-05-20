// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(4289,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_DECODE_SUPPORT_DATA_0020
    {
        public uint NodeIndex;
        public D3D12DDI_VIDEO_DECODE_CONFIGURATION_0020 Configuration;
        public uint Width;
        public uint Height;
        public int DecodeFormat;
        public int FrameRate;
        public uint BitRate;
        public D3D12DDI_VIDEO_DECODE_SUPPORT_FLAGS_0020 SupportFlags;
        public D3D12DDI_VIDEO_DECODE_CONFIGURATION_FLAGS_0020 ConfigurationFlags;
        public D3D12DDI_VIDEO_DECODE_TIER_0020 DecodeTier;
    }
}
