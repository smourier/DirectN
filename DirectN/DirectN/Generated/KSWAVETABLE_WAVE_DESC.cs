// generated from <Windows SDK Path>\shared\ksmedia.h
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
