// generated from <Windows SDK Path>\um\dmusicc.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DMUS_PORTPARAMS8
    {
        public uint dwSize;
        public uint dwValidParams;
        public uint dwVoices;
        public uint dwChannelGroups;
        public uint dwAudioChannels;
        public uint dwSampleRate;
        public uint dwEffectFlags;
        public bool fShare;
        public uint dwFeatures;
    }
}
