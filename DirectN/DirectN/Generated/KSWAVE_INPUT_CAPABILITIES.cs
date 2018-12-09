// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(2541,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSWAVE_INPUT_CAPABILITIES
    {
        public uint MaximumChannelsPerConnection;
        public uint MinimumBitsPerSample;
        public uint MaximumBitsPerSample;
        public uint MinimumSampleFrequency;
        public uint MaximumSampleFrequency;
        public uint TotalConnections;
        public uint ActiveConnections;
    }
}
