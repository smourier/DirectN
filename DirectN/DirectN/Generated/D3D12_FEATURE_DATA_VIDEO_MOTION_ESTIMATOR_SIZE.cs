// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR_SIZE
    {
        public uint NodeIndex;
        public DXGI_FORMAT InputFormat;
        public D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE BlockSize;
        public D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION Precision;
        public D3D12_VIDEO_SIZE_RANGE SizeRange;
        public bool Protected;
        public ulong MotionVectorHeapMemoryPoolL0Size;
        public ulong MotionVectorHeapMemoryPoolL1Size;
        public ulong MotionEstimatorMemoryPoolL0Size;
        public ulong MotionEstimatorMemoryPoolL1Size;
    }
}
