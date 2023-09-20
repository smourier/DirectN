// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AM_STREAM_INFO
    {
        public long tStart;
        public long tStop;
        public uint dwStartCookie;
        public uint dwStopCookie;
        public uint dwFlags;
    }
}
