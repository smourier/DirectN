// generated from <Windows SDK Path>\shared\dmusbuff.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DMUS_EVENTHEADER
    {
        public uint cbEvent;
        public uint dwChannelGroup;
        public long rtDelta;
        public uint dwFlags;
    }
}
