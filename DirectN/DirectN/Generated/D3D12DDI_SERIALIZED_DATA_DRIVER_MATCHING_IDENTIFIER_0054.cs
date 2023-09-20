// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER_0054
    {
        public Guid DriverOpaqueGUID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] DriverOpaqueVersioningData;
    }
}
