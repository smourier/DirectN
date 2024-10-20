// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputTouchState
    {
        public ulong touchId;
        public uint sensorIndex;
        public float positionX;
        public float positionY;
        public float pressure;
        public float proximity;
        public float contactRectTop;
        public float contactRectLeft;
        public float contactRectRight;
        public float contactRectBottom;
    }
}
