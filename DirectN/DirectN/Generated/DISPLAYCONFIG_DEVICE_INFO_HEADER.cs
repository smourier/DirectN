// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;
using DISPLAYCONFIG_DEVICE_INFO_TYPE = DirectN.DISPLAYCONFIG_DEVICE_INFO;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_DEVICE_INFO_HEADER
    {
        public DISPLAYCONFIG_DEVICE_INFO_TYPE type;
        public uint size;
        public LUID adapterId;
        public uint id;
    }
}
