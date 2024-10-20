// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputTouchSensorInfo
    {
        public GameInputKind mappedInputKinds;
        public GameInputLabel label;
        public GameInputLocation location;
        public uint locationId;
        public ulong resolutionX;
        public ulong resolutionY;
        public GameInputTouchShape shape;
        public float aspectRatio;
        public float orientation;
        public float physicalWidth;
        public float physicalHeight;
        public float maxPressure;
        public float maxProximity;
        public uint maxTouchPoints;
    }
}
