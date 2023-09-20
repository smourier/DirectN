// generated from <Windows SDK Path>\um\dxcore_interface.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXCoreHardwareIDParts
    {
        public uint vendorID;
        public uint deviceID;
        public uint subSystemID;
        public uint subVendorID;
        public uint revisionID;
    }
}
