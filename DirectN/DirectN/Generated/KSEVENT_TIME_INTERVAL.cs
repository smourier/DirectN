// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSEVENT_TIME_INTERVAL
    {
        public KSEVENTDATA EventData;
        public long TimeBase;
        public long Interval;
    }
}
