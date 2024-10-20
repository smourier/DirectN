// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputRumbleParams
    {
        public float lowFrequency;
        public float highFrequency;
        public float leftTrigger;
        public float rightTrigger;
    }
}
