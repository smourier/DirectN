// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRPOLYDRAW
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public uint cptl;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _POINTL[] aptl;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] abTypes;
    }
}
