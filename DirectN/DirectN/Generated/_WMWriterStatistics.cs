// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(1471,9)
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
