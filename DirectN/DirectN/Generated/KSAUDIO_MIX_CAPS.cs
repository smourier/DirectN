﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(1855,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSAUDIO_MIX_CAPS
    {
        public bool Mute;
        public int Minimum;
        public int Maximum;
        public __struct_ksmedia_46__union_0 __union_3;
    }
}
