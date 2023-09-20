// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO
    {
        public uint NodeIndex;
        public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceMode;
        public D3D12_VIDEO_PROCESS_FILTER_FLAGS Filters;
        public D3D12_VIDEO_PROCESS_FEATURE_FLAGS FeatureSupport;
        public DXGI_RATIONAL InputFrameRate;
        public DXGI_RATIONAL OutputFrameRate;
        public bool EnableAutoProcessing;
        public uint PastFrames;
        public uint FutureFrames;
    }
}
