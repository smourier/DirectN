// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcore_interface.h(68,1)
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
