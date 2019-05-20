// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12video.h(295,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC
    {
        public DXGI_FORMAT Format;
        public DXGI_COLOR_SPACE_TYPE ColorSpace;
        public DXGI_RATIONAL SourceAspectRatio;
        public DXGI_RATIONAL DestinationAspectRatio;
        public DXGI_RATIONAL FrameRate;
        public D3D12_VIDEO_SIZE_RANGE SourceSizeRange;
        public D3D12_VIDEO_SIZE_RANGE DestinationSizeRange;
        public bool EnableOrientation;
        public D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterFlags;
        public D3D12_VIDEO_FRAME_STEREO_FORMAT StereoFormat;
        public D3D12_VIDEO_FIELD_TYPE FieldType;
        public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceMode;
        public bool EnableAlphaBlending;
        public D3D12_VIDEO_PROCESS_LUMA_KEY LumaKey;
        public uint NumPastFrames;
        public uint NumFutureFrames;
        public bool EnableAutoProcessing;
    }
}
