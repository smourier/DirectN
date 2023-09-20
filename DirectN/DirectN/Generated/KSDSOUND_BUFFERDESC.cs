// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDSOUND_BUFFERDESC
    {
        public uint Flags;
        public uint Control;
        public tWAVEFORMATEX WaveFormatEx;
    }
}
