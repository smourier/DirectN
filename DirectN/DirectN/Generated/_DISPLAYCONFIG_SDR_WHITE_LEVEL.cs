// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(3192,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DISPLAYCONFIG_SDR_WHITE_LEVEL
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
        public uint SDRWhiteLevel;
    }
}
