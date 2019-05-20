// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12video.h(2473,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT
    {
        public uint NodeIndex;
        public bool VideoDecodeSupport;
        public bool VideoProcessSupport;
        public bool VideoEncodeSupport;
    }
}
