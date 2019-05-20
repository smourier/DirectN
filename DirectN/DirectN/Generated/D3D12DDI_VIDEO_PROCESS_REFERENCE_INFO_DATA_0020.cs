// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(4428,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_PROCESS_REFERENCE_INFO_DATA_0020
    {
        public uint NodeIndex;
        public D3D12DDI_VIDEO_PROCESS_DEINTERLACE_FLAGS_0020 DeinterlaceMode;
        public D3D12DDI_VIDEO_PROCESS_FILTER_FLAGS_0020 Filters;
        public D3D12DDI_VIDEO_PROCESS_FEATURE_SUPPORT_FLAGS_0020 FeatureSupport;
        public int InputFrameRate;
        public int OutputFrameRate;
        public bool EnableAutoProcessing;
        public uint PastFrames;
        public uint FutureFrames;
    }
}
