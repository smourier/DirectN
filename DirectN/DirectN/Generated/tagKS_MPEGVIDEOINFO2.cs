// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(4202,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_MPEGVIDEOINFO2
    {
        public tagKS_VIDEOINFOHEADER2 hdr;
        public uint dwStartTimeCode;
        public uint cbSequenceHeader;
        public uint dwProfile;
        public uint dwLevel;
        public uint dwFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public uint[] bSequenceHeader;
    }
}
