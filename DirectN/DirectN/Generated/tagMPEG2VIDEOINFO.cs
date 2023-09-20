// generated from <Windows SDK Path>\um\dvdmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMPEG2VIDEOINFO
    {
        public tagVIDEOINFOHEADER2 hdr;
        public uint dwStartTimeCode;
        public uint cbSequenceHeader;
        public uint dwProfile;
        public uint dwLevel;
        public uint dwFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public uint[] dwSequenceHeader;
    }
}
