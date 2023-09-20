// generated from <Windows SDK Path>\um\amvideo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMPEG1VIDEOINFO
    {
        public tagVIDEOINFOHEADER hdr;
        public uint dwStartTimeCode;
        public uint cbSequenceHeader;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] bSequenceHeader;
    }
}
