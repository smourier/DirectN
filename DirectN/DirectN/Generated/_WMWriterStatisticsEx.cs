// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WMWriterStatisticsEx
    {
        public uint dwBitratePlusOverhead;
        public uint dwCurrentSampleDropRateInQueue;
        public uint dwCurrentSampleDropRateInCodec;
        public uint dwCurrentSampleDropRateInMultiplexer;
        public uint dwTotalSampleDropsInQueue;
        public uint dwTotalSampleDropsInCodec;
        public uint dwTotalSampleDropsInMultiplexer;
    }
}
