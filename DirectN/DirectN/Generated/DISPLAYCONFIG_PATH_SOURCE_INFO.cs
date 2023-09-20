// generated from <Windows SDK Path>\um\wingdi.h
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
