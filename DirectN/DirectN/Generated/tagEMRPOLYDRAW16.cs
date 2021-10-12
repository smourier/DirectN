// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(5768,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRPOLYDRAW16
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public uint cpts;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagPOINTS[] apts;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] abTypes;
    }
}
