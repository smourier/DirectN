// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dvdmedia.h(325,9)
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
