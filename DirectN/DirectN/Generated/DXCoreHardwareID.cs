// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxcore_interface.h(64,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXCoreHardwareID
    {
        public uint vendorID;
        public uint deviceID;
        public uint subSysID;
        public uint revision;
    }
}
