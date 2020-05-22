// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(5789,9)
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
