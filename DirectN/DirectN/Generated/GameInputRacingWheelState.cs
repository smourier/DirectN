// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputRacingWheelState
    {
        public GameInputRacingWheelButtons buttons;
        public int patternShifterGear;
        public float wheel;
        public float throttle;
        public float brake;
        public float clutch;
        public float handbrake;
    }
}
