﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(5605,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_VIDEODECODER_STATUS_S
    {
        public KSIDENTIFIER Property;
        public uint NumberOfLines;
        public uint SignalLocked;
    }
}
