// generated from <Windows SDK Path>\um\d3d12video.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_AV1_RESTORATION_CONFIG
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE[] FrameRestorationType;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE[] LoopRestorationPixelSize;
    }
}
