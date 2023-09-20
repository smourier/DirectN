// generated from <Windows SDK Path>\um\dxcore_interface.h
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
