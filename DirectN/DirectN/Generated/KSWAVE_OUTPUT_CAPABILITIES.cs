// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(2596,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSWAVE_OUTPUT_CAPABILITIES
    {
        public uint MaximumChannelsPerConnection;
        public uint MinimumBitsPerSample;
        public uint MaximumBitsPerSample;
        public uint MinimumSampleFrequency;
        public uint MaximumSampleFrequency;
        public uint TotalConnections;
        public uint StaticConnections;
        public uint StreamingConnections;
        public uint ActiveConnections;
        public uint ActiveStaticConnections;
        public uint ActiveStreamingConnections;
        public uint Total3DConnections;
        public uint Static3DConnections;
        public uint Streaming3DConnections;
        public uint Active3DConnections;
        public uint ActiveStatic3DConnections;
        public uint ActiveStreaming3DConnections;
        public uint TotalSampleMemory;
        public uint FreeSampleMemory;
        public uint LargestFreeContiguousSampleMemory;
    }
}
