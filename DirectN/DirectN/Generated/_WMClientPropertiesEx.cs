// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(1525,9)
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
