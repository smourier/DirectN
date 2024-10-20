// generated from <Windows SDK Path>\um\dmusicc.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DMUS_SYNTHSTATS8
    {
        public uint dwSize;
        public uint dwValidStats;
        public uint dwVoices;
        public uint dwTotalCPU;
        public uint dwCPUPerVoice;
        public uint dwLostNotes;
        public uint dwFreeMemory;
        public int lPeakVolume;
        public uint dwSynthMemUse;
    }
}
