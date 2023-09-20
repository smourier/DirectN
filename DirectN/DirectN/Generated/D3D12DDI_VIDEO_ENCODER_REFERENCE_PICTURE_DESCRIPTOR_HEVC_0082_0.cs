// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC_0082_0
    {
        public uint ReconstructedPictureResourceIndex;
        public bool IsRefUsedByCurrentPic;
        public bool IsLongTermReference;
        public uint PictureOrderCountNumber;
        public uint TemporalLayerIndex;
    }
}
