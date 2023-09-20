// generated from <Windows SDK Path>\um\strmif.h
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
