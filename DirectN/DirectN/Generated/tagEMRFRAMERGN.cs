﻿// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(5817,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRFRAMERGN
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public uint cbRgnData;
        public uint ihBrush;
        public tagSIZE szlStroke;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] RgnData;
    }
}
