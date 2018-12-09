// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(1825,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagWMMPEG2VIDEOINFO
    {
        public tagWMVIDEOINFOHEADER2 hdr;
        public uint dwStartTimeCode;
        public uint cbSequenceHeader;
        public uint dwProfile;
        public uint dwLevel;
        public uint dwFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public uint[] dwSequenceHeader;
    }
}
