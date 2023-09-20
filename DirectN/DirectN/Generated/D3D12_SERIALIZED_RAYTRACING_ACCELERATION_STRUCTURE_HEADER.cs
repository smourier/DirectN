// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER
    {
        public D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER DriverMatchingIdentifier;
        public ulong SerializedSizeInBytesIncludingHeader;
        public ulong DeserializedSizeInBytes;
        public ulong NumBottomLevelAccelerationStructurePointersAfterHeader;
    }
}
