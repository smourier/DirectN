// generated from <Windows SDK Path>\um\mfreadwrite.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MF_SINK_WRITER_STATISTICS
    {
        public uint cb;
        public long llLastTimestampReceived;
        public long llLastTimestampEncoded;
        public long llLastTimestampProcessed;
        public long llLastStreamTickReceived;
        public long llLastSinkSampleRequest;
        public ulong qwNumSamplesReceived;
        public ulong qwNumSamplesEncoded;
        public ulong qwNumSamplesProcessed;
        public ulong qwNumStreamTicksReceived;
        public uint dwByteCountQueued;
        public ulong qwByteCountProcessed;
        public uint dwNumOutstandingSinkSampleRequests;
        public uint dwAverageSampleRateReceived;
        public uint dwAverageSampleRateEncoded;
        public uint dwAverageSampleRateProcessed;
    }
}
