// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public D3D12_VIDEO_PROCESS_INPUT_STREAM[] InputStream;
        public D3D12_VIDEO_PROCESS_TRANSFORM Transform;
        public D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS Flags;
        public D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE RateInfo;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public int[] FilterLevels;
        public D3D12_VIDEO_PROCESS_ALPHA_BLENDING AlphaBlending;
    }
}
