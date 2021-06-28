// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(4191,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_MPEG1VIDEOINFO
    {
        public tagKS_VIDEOINFOHEADER hdr;
        public uint dwStartTimeCode;
        public uint cbSequenceHeader;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] bSequenceHeader;
    }
}
