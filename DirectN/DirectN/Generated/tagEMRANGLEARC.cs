// generated from <Windows SDK Path>\um\wingdi.h
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
