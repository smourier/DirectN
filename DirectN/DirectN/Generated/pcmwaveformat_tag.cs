﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mmeapi.h(312,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct pcmwaveformat_tag
    {
        public waveformat_tag wf;
        public ushort wBitsPerSample;
    }
}
