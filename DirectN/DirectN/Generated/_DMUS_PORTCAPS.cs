// generated from <Windows SDK Path>\um\dmusicc.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _DMUS_PORTCAPS
    {
        public uint dwSize;
        public uint dwFlags;
        public Guid guidPort;
        public uint dwClass;
        public uint dwType;
        public uint dwMemorySize;
        public uint dwMaxChannelGroups;
        public uint dwMaxVoices;
        public uint dwMaxAudioChannels;
        public uint dwEffectFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string wszDescription;
    }
}
