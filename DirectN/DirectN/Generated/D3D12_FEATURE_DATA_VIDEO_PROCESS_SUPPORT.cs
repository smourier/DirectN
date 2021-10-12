// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(1337,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT
    {
        public uint NodeIndex;
        public D3D12_VIDEO_SAMPLE InputSample;
        public D3D12_VIDEO_FIELD_TYPE InputFieldType;
        public D3D12_VIDEO_FRAME_STEREO_FORMAT InputStereoFormat;
        public DXGI_RATIONAL InputFrameRate;
        public D3D12_VIDEO_FORMAT OutputFormat;
        public D3D12_VIDEO_FRAME_STEREO_FORMAT OutputStereoFormat;
        public DXGI_RATIONAL OutputFrameRate;
        public D3D12_VIDEO_PROCESS_SUPPORT_FLAGS SupportFlags;
        public D3D12_VIDEO_SCALE_SUPPORT ScaleSupport;
        public D3D12_VIDEO_PROCESS_FEATURE_FLAGS FeatureSupport;
        public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceSupport;
        public D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS AutoProcessingSupport;
        public D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterSupport;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3D12_VIDEO_PROCESS_FILTER_RANGE[] FilterRangeSupport;
    }
}
