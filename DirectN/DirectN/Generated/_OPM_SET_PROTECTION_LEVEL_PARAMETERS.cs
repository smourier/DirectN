// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\opmapi.h(378,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _OPM_SET_PROTECTION_LEVEL_PARAMETERS
    {
        public uint ulProtectionType;
        public uint ulProtectionLevel;
        public uint Reserved;
        public uint Reserved2;
    }
}
