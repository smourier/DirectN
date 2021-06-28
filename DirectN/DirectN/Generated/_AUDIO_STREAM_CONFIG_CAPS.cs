// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(8755,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _AUDIO_STREAM_CONFIG_CAPS
    {
        public Guid guid;
        public uint MinimumChannels;
        public uint MaximumChannels;
        public uint ChannelsGranularity;
        public uint MinimumBitsPerSample;
        public uint MaximumBitsPerSample;
        public uint BitsPerSampleGranularity;
        public uint MinimumSampleFrequency;
        public uint MaximumSampleFrequency;
        public uint SampleFrequencyGranularity;
    }
}
