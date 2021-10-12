// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(7004,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC
    {
        public D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS Flags;
        public D3D12_VIDEO_ENCODER_INTRA_REFRESH IntraRefreshConfig;
        public D3D12_VIDEO_ENCODER_RATE_CONTROL RateControl;
        public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC PictureTargetResolution;
        public D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE SelectedLayoutMode;
        public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA FrameSubregionsLayoutData;
        public D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE CodecGopSequence;
    }
}
