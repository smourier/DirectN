// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(13785,9)
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
