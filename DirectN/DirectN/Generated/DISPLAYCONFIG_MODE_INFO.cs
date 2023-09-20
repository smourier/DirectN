// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_MODE_INFO
    {
        public DISPLAYCONFIG_MODE_INFO_TYPE infoType;
        public uint id;
        public LUID adapterId;
        public DISPLAYCONFIG_MODE_INFO__union_0 __union_3;
    }
}
