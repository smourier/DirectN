// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRPOLYTEXTOUTA
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public uint iGraphicsMode;
        public float exScale;
        public float eyScale;
        public int cStrings;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagEMRTEXT[] aemrtext;
    }
}
