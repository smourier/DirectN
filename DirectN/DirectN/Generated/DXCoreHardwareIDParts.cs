// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcore_interface.h(76,1)
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
