// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wingdi.h(2946,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_PATH_SOURCE_INFO
    {
        public LUID adapterId;
        public uint id;
        public DISPLAYCONFIG_PATH_SOURCE_INFO__union_0 __union_2;
        public uint statusFlags;
    }
}
