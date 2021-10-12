// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(2723,9)
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
