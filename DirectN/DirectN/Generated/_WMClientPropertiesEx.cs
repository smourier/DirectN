// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WMClientPropertiesEx
    {
        public uint cbSize;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszIPAddress;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszPort;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszDNSName;
    }
}
