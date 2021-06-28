// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfreadwrite.h(1163,9)
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
