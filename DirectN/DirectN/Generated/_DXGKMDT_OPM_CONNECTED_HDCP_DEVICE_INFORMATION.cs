// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_CONNECTED_HDCP_DEVICE_INFORMATION
    {
        public _DXGKMDT_OPM_RANDOM_NUMBER rnRandomNumber;
        public uint ulStatusFlags;
        public uint ulHDCPFlags;
        public _DXGKMDT_OPM_HDCP_KEY_SELECTION_VECTOR ksvB;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)] 
        public byte[] Reserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] Reserved2;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] Reserved3;
    }
}
