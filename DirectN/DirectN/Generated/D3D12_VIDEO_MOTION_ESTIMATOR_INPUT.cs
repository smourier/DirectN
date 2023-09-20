// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_MOTION_ESTIMATOR_INPUT
    {
        public IntPtr pInputTexture2D;
        public uint InputSubresourceIndex;
        public IntPtr pReferenceTexture2D;
        public uint ReferenceSubresourceIndex;
        public IntPtr pHintMotionVectorHeap;
    }
}
