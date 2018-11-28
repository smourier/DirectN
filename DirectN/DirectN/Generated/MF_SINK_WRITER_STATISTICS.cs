using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MF_SINK_WRITER_STATISTICS
    {
        public int cb;
        public long llLastTimestampReceived;
        public long llLastTimestampEncoded;
        public long llLastTimestampProcessed;
        public long llLastStreamTickReceived;
        public long llLastSinkSampleRequest;
        public ulong qwNumSamplesReceived;
        public ulong qwNumSamplesEncoded;
        public ulong qwNumSamplesProcessed;
        public ulong qwNumStreamTicksReceived;
        public int dwByteCountQueued;
        public ulong qwByteCountProcessed;
        public int dwNumOutstandingSinkSampleRequests;
        public int dwAverageSampleRateReceived;
        public int dwAverageSampleRateEncoded;
        public int dwAverageSampleRateProcessed;
    }
}
