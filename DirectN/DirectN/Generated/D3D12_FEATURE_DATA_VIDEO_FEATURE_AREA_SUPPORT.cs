// generated from <Windows SDK Path>\um\d3d12video.h
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
