// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(9193,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_PROCESS_SUPPORT_DATA_0032
    {
        public uint NodeIndex;
        public D3D12DDI_VIDEO_SAMPLE_DESCRIPTION_0020 InputSample;
        public D3D12DDI_VIDEO_FIELD_TYPE_0020 InputFieldType;
        public D3D12DDI_VIDEO_FRAME_STEREO_FORMAT_0020 InputStereoFormat;
        public DXGI_RATIONAL InputFrameRate;
        public D3D12DDI_VIDEO_FORMAT_DESCRIPTION_0020 OutputFormat;
        public D3D12DDI_VIDEO_FRAME_STEREO_FORMAT_0020 OutputStereoFormat;
        public DXGI_RATIONAL OutputFrameRate;
        public D3D12DDI_VIDEO_PROCESS_SUPPORT_FLAGS_0022 SupportFlags;
        public D3D12DDI_VIDEO_SCALE_SUPPORT_0032 ScaleSupport;
        public D3D12DDI_VIDEO_PROCESS_FEATURE_SUPPORT_FLAGS_0020 FeatureSupport;
        public D3D12DDI_VIDEO_PROCESS_DEINTERLACE_FLAGS_0020 DeinterlaceSupport;
        public D3D12DDI_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS_0022 AutoProcessingSupport;
        public D3D12DDI_VIDEO_PROCESS_FILTER_FLAGS_0020 FilterSupport;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public D3D12DDI_VIDEO_PROCESS_FILTER_RANGE_0020[] FilterRangeSupport;
    }
}
