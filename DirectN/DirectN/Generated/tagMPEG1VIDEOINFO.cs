// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\amvideo.h(439,9)
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
