﻿// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\mmeapi.h(2231,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMIXERLINECONTROLSW
    {
        public uint cbStruct;
        public uint dwLineID;
        public tagMIXERLINECONTROLSW__union_0 __union_2;
        public uint cControls;
        public uint cbmxctrl;
        public IntPtr pamxctrl;
    }
}
