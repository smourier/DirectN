// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_METADATA_STATISTICS_0083_0
    {
        public ulong AverageQP;
        public ulong IntraCodingUnitsCount;
        public ulong InterCodingUnitsCount;
        public ulong SkipCodingUnitsCount;
        public ulong AverageMotionEstimationXDirection;
        public ulong AverageMotionEstimationYDirection;
    }
}
