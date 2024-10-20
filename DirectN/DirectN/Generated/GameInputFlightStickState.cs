// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputFlightStickState
    {
        public GameInputFlightStickButtons buttons;
        public GameInputSwitchPosition hatSwitch;
        public float roll;
        public float pitch;
        public float yaw;
        public float throttle;
    }
}
