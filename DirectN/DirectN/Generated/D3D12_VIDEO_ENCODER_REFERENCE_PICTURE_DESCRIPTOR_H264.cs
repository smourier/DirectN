// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_H264
    {
        public uint ReconstructedPictureResourceIndex;
        public bool IsLongTermReference;
        public uint LongTermPictureIdx;
        public uint PictureOrderCountNumber;
        public uint FrameDecodingOrderNumber;
        public uint TemporalLayerIndex;
    }
}
