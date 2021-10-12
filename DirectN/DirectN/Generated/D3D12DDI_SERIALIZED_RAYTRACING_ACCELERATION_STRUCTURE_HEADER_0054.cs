// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(8020,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER_0054
    {
        public D3D12DDI_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER_0054 DriverMatchingIdentifier;
        public ulong SerializedSizeInBytesIncludingHeader;
        public ulong DeserializedSizeInBytes;
        public ulong NumBottomLevelAccelerationStructurePointersAfterHeader;
    }
}
