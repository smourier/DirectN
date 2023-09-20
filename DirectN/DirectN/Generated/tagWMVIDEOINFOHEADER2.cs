// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagWMVIDEOINFOHEADER2
    {
        public tagRECT rcSource;
        public tagRECT rcTarget;
        public uint dwBitRate;
        public uint dwBitErrorRate;
        public long AvgTimePerFrame;
        public uint dwInterlaceFlags;
        public uint dwCopyProtectFlags;
        public uint dwPictAspectRatioX;
        public uint dwPictAspectRatioY;
        public uint dwReserved1;
        public uint dwReserved2;
        public tagBITMAPINFOHEADER bmiHeader;
    }
}
