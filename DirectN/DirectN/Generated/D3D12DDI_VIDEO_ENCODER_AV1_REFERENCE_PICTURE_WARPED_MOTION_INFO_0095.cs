// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO_0095
    {
        public D3D12DDI_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_0095 TransformationType;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public int[] TransformationMatrix;
        public bool InvalidAffineSet;
    }
}
