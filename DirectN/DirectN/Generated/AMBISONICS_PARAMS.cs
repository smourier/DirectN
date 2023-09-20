// generated from <Windows SDK Path>\um\audioclient.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AMBISONICS_PARAMS
    {
        public uint u32Size;
        public uint u32Version;
        public AMBISONICS_TYPE u32Type;
        public AMBISONICS_CHANNEL_ORDERING u32ChannelOrdering;
        public AMBISONICS_NORMALIZATION u32Normalization;
        public uint u32Order;
        public uint u32NumChannels;
        public IntPtr pu32ChannelMap;
    }
}
