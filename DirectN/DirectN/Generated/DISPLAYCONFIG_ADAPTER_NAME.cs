// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(3106,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct DISPLAYCONFIG_ADAPTER_NAME
    {
        public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string adapterDevicePath;
    }
}
