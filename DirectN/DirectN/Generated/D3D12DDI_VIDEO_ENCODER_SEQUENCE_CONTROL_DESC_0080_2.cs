// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(13077,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC_0080_2
    {
        public D3D12DDI_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS_0080 Flags;
        public D3D12DDI_VIDEO_ENCODER_INTRA_REFRESH_0080 IntraRefreshConfig;
        public D3D12DDI_VIDEO_ENCODER_RATE_CONTROL_0080_2 RateControl;
        public D3D12DDI_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC_0080 PictureTargetResolution;
        public D3D12DDI_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_0080 SelectedLayoutMode;
        public D3D12DDI_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_0080_2 FrameSubregionsLayoutData;
    }
}
