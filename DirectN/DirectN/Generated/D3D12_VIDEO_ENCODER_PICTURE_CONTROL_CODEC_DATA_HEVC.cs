// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC
    {
        public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_HEVC_FLAGS Flags;
        public D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC FrameType;
        public uint slice_pic_parameter_set_id;
        public uint PictureOrderCountNumber;
        public uint TemporalLayerIndex;
        public uint List0ReferenceFramesCount;
        public IntPtr pList0ReferenceFrames;
        public uint List1ReferenceFramesCount;
        public IntPtr pList1ReferenceFrames;
        public uint ReferenceFramesReconPictureDescriptorsCount;
        public IntPtr pReferenceFramesReconPictureDescriptors;
        public uint List0RefPicModificationsCount;
        public IntPtr pList0RefPicModifications;
        public uint List1RefPicModificationsCount;
        public IntPtr pList1RefPicModifications;
        public uint QPMapValuesCount;
        public IntPtr pRateControlQPMap;
    }
}
