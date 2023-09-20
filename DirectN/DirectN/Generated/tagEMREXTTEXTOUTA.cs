// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMREXTTEXTOUTA
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public uint iGraphicsMode;
        public float exScale;
        public float eyScale;
        public tagEMRTEXT emrtext;
    }
}
