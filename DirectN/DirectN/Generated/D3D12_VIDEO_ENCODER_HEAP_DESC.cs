// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_HEAP_DESC
    {
        public uint NodeMask;
        public D3D12_VIDEO_ENCODER_HEAP_FLAGS Flags;
        public D3D12_VIDEO_ENCODER_CODEC EncodeCodec;
        public D3D12_VIDEO_ENCODER_PROFILE_DESC EncodeProfile;
        public D3D12_VIDEO_ENCODER_LEVEL_SETTING EncodeLevel;
        public uint ResolutionsListCount;
        public IntPtr pResolutionList;
    }
}
