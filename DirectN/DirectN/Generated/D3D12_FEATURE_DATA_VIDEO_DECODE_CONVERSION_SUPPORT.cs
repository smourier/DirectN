// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12video.h(848,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT
    {
        public uint NodeIndex;
        public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;
        public D3D12_VIDEO_SAMPLE DecodeSample;
        public D3D12_VIDEO_FORMAT OutputFormat;
        public DXGI_RATIONAL FrameRate;
        public uint BitRate;
        public D3D12_VIDEO_DECODE_CONVERSION_SUPPORT_FLAGS SupportFlags;
        public D3D12_VIDEO_SCALE_SUPPORT ScaleSupport;
    }
}
