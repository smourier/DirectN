﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(984,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSAUDIO_POSITION
    {
        public ulong PlayOffset;
        public ulong WriteOffset;
    }
}
