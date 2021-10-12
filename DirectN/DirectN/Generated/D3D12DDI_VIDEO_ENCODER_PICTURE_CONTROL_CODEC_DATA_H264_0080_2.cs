// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(13009,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_0080_2
    {
        public D3D12DDI_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_FLAGS_0080 Flags;
        public D3D12DDI_VIDEO_ENCODER_FRAME_TYPE_H264_0080 FrameType;
        public byte pic_parameter_set_id;
        public byte idr_pic_id;
        public byte disable_deblocking_filter_idc;
        public uint PictureOrderCountNumber;
        public uint FrameDecodingOrderNumber;
        public uint TemporalLayerIndex;
        public uint List0ReferenceFramesCount;
        public IntPtr pList0ReferenceFrames;
        public uint List1ReferenceFramesCount;
        public IntPtr pList1ReferenceFrames;
        public uint ReferenceFramesReconPictureDescriptorsCount;
        public IntPtr pReferenceFramesReconPictureDescriptors;
        public byte adaptive_ref_pic_marking_mode_flag;
        public uint RefPicMarkingOperationsCommandsCount;
        public IntPtr pRefPicMarkingOperationsCommands;
        public uint QPMapValuesCount;
        public IntPtr pRateControlQPMap;
    }
}
