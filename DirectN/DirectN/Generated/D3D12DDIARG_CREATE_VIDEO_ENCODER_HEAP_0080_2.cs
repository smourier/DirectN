// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12861,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_VIDEO_ENCODER_HEAP_0080_2
    {
        public uint NodeMask;
        public D3D12DDI_VIDEO_ENCODER_HEAP_FLAGS_0080 Flags;
        public D3D12DDI_VIDEO_ENCODER_CODEC_0080 EncodeCodec;
        public D3D12DDI_VIDEO_ENCODER_PROFILE_DESC_0080_2 EncodeProfile;
        public D3D12DDI_VIDEO_ENCODER_LEVEL_SETTING_0080_2 EncodeLevel;
        public uint ResolutionsListCount;
        public IntPtr pResolutionList;
    }
}
