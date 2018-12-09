// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(1485,9)
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
