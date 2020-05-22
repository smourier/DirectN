// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(2738,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _DISPLAY_DEVICEW
    {
        public uint cb;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string DeviceName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string DeviceString;
        public uint StateFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string DeviceKey;
    }
}
