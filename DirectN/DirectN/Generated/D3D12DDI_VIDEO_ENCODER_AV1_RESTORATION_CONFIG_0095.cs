// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_AV1_RESTORATION_CONFIG_0095
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public D3D12DDI_VIDEO_ENCODER_AV1_RESTORATION_TYPE_0095[] FrameRestorationType;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public D3D12DDI_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_0095[] LoopRestorationPixelSize;
    }
}
