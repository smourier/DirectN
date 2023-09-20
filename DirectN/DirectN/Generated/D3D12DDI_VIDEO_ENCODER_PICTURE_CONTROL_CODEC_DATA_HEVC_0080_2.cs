// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC_0080_2
    {
        public D3D12DDI_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC_FLAGS_0080 Flags;
        public D3D12DDI_VIDEO_ENCODER_FRAME_TYPE_HEVC_0080 FrameType;
        public byte slice_pic_parameter_set_id;
        public uint PictureOrderCountNumber;
        public uint TemporalLayerIndex;
        public uint List0ReferenceFramesCount;
        public IntPtr pList0ReferenceFrames;
        public uint List1ReferenceFramesCount;
        public IntPtr pList1ReferenceFrames;
        public uint ReferenceFramesReconPictureDescriptorsCount;
        public IntPtr pReferenceFramesReconPictureDescriptors;
        public uint QPMapValuesCount;
        public IntPtr pRateControlQPMap;
    }
}
