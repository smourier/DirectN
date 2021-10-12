// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(11487,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_MOTION_ESTIMATOR_DATA_0053
    {
        public uint NodeIndex;
        public DXGI_FORMAT InputFormat;
        public D3D12DDI_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAGS_0053 BlockSizeFlags;
        public D3D12DDI_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS_0053 PrecisionFlags;
        public D3D12DDI_VIDEO_MOTION_ESTIMATOR_DIFFERENCES_METRIC_FLAGS_0053 DifferencesMetricFlags;
        public D3D12DDI_VIDEO_SIZE_RANGE_0032 SizeRange;
    }
}
