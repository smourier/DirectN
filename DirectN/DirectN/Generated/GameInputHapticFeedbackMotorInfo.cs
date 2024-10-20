// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputHapticFeedbackMotorInfo
    {
        public GameInputRumbleMotors mappedRumbleMotors;
        public GameInputLocation location;
        public uint locationId;
        public uint waveformCount;
        public IntPtr waveformInfo;
    }
}
