// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRATE
    {
        public long PresentationStart;
        public long Duration;
        public KSIDENTIFIER Interface;
        public int Rate;
        public uint Flags;
    }
}
