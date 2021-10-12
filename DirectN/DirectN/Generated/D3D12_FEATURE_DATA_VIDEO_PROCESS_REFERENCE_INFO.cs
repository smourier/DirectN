// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(1362,9)
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
