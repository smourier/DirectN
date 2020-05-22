// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(5680,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRANGLEARC
    {
        public tagEMR emr;
        public _POINTL ptlCenter;
        public uint nRadius;
        public float eStartAngle;
        public float eSweepAngle;
    }
}
