// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WMWriterStatistics
    {
        public ulong qwSampleCount;
        public ulong qwByteCount;
        public ulong qwDroppedSampleCount;
        public ulong qwDroppedByteCount;
        public uint dwCurrentBitrate;
        public uint dwAverageBitrate;
        public uint dwExpectedBitrate;
        public uint dwCurrentSampleRate;
        public uint dwAverageSampleRate;
        public uint dwExpectedSampleRate;
    }
}
