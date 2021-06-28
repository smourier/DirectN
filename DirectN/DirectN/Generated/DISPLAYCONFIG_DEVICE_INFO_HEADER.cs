// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(3051,9)
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
