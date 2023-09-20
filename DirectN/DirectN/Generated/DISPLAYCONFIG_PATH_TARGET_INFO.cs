// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;
using DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY = DirectN.DISPLAYCONFIG_OUTPUT_TECHNOLOGY;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_PATH_TARGET_INFO
    {
        public LUID adapterId;
        public uint id;
        public DISPLAYCONFIG_PATH_TARGET_INFO__union_0 __union_2;
        public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;
        public DISPLAYCONFIG_ROTATION rotation;
        public DISPLAYCONFIG_SCALING scaling;
        public DISPLAYCONFIG_RATIONAL refreshRate;
        public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
        public bool targetAvailable;
        public uint statusFlags;
    }
}
