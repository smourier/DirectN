// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(9600,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_PROCESSOR_INPUT_STREAM_DESC_0043
    {
        public int Format;
        public int ColorSpace;
        public int SourceAspectRatio;
        public int DestinationAspectRatio;
        public int FrameRate;
        public D3D12DDI_VIDEO_SIZE_RANGE_0032 SourceSizeRange;
        public D3D12DDI_VIDEO_SIZE_RANGE_0032 DestinationSizeRange;
        public bool EnableOrientation;
        public D3D12DDI_VIDEO_PROCESS_FILTER_FLAGS_0020 FilterFlags;
        public D3D12DDI_VIDEO_FRAME_STEREO_FORMAT_0020 StereoFormat;
        public D3D12DDI_VIDEO_PROCESS_DEINTERLACE_FLAGS_0020 DeinterlaceMode;
        public bool EnableAlphaBlending;
        public D3D12DDI_VIDEO_PROCESS_LUMA_KEY_0020 LumaKey;
        public uint NumPastFrames;
        public uint NumFutureFrames;
        public bool EnableAutoProcessing;
    }
}
