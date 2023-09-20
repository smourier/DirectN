// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDATARANGE_MUSIC
    {
        public KSDATAFORMAT DataRange;
        public Guid Technology;
        public uint Channels;
        public uint Notes;
        public uint ChannelMask;
    }
}
