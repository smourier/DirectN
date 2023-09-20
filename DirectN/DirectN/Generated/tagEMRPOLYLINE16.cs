// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRPOLYLINE16
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public uint cpts;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagPOINTS[] apts;
    }
}
