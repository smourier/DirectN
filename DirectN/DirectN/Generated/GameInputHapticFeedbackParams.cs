// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputHapticFeedbackParams
    {
        public uint waveformIndex;
        public ulong duration;
        public float intensity;
        public uint playCount;
        public ulong repeatDelay;
    }
}
