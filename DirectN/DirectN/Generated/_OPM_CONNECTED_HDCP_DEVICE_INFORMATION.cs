// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\opmapi.h(304,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _OPM_CONNECTED_HDCP_DEVICE_INFORMATION
    {
        public _OPM_RANDOM_NUMBER rnRandomNumber;
        public uint ulStatusFlags;
        public uint ulHDCPFlags;
        public _OPM_HDCP_KEY_SELECTION_VECTOR ksvB;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)] 
        public byte[] Reserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] Reserved2;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] Reserved3;
    }
}
