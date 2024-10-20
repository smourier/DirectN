// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO
    {
        public D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION TransformationType;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public int[] TransformationMatrix;
        public bool InvalidAffineSet;
    }
}
