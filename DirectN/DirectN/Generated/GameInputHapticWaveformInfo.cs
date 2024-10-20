// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputHapticWaveformInfo
    {
        public GameInputUsage usage;
        public bool isDurationSupported;
        public bool isIntensitySupported;
        public bool isRepeatSupported;
        public bool isRepeatDelaySupported;
        public ulong defaultDuration;
    }
}
