// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagTIMECODE_SAMPLE
    {
        public long qwTick;
        public _timecode timecode;
        public uint dwUser;
        public uint dwFlags;
    }
}
