// generated from <Windows SDK Path>\um\wmcodecdsp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _TOC_ENTRY_DESCRIPTOR
    {
        public ulong qwStartTime;
        public ulong qwEndTime;
        public ulong qwStartPacketOffset;
        public ulong qwEndPacketOffset;
        public ulong qwRepresentativeFrameTime;
    }
}
