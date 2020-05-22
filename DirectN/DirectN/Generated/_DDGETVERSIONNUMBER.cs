// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddkmapi.h(56,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDGETVERSIONNUMBER
    {
        public uint ddRVal;
        public uint dwMajorVersion;
        public uint dwMinorVersion;
    }
}
