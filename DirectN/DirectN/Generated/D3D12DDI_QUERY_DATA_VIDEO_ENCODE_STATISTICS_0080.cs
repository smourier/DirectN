// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12639,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_QUERY_DATA_VIDEO_ENCODE_STATISTICS_0080
    {
        public uint AverageQP;
        public ulong IntraCodingUnitsCount;
        public ulong InterCodingUnitsCount;
        public ulong SkipCodingUnitsCount;
        public ulong AverageBitsPerIntraCodingUnit;
        public ulong AverageBitsPerInterCodingUnit;
        public uint AverageMotionEstimationXDirection;
        public uint AverageMotionEstimationYDirection;
    }
}
