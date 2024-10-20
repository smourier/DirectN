// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputMouseInfo
    {
        public GameInputMouseButtons supportedButtons;
        public uint sampleRate;
        public uint sensorDpi;
        public bool hasWheelX;
        public bool hasWheelY;
    }
}
