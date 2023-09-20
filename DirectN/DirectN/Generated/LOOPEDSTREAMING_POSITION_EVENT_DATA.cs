// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct LOOPEDSTREAMING_POSITION_EVENT_DATA
    {
        public KSEVENTDATA KsEventData;
        public ulong Position;
    }
}
