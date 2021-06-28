// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(2500,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSWAVETABLE_WAVE_DESC
    {
        public KSIDENTIFIER Identifier;
        public uint Size;
        public bool Looped;
        public uint LoopPoint;
        public bool InROM;
        public KSDATAFORMAT Format;
    }
}
