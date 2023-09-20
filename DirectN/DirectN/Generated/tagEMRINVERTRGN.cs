// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRINVERTRGN
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public uint cbRgnData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] RgnData;
    }
}
