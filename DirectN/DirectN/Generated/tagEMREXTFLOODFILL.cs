﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(5692,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMREXTFLOODFILL
    {
        public tagEMR emr;
        public _POINTL ptlStart;
        public uint crColor;
        public uint iMode;
    }
}
