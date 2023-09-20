// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public partial struct _DISPLAY_DEVICEA
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
