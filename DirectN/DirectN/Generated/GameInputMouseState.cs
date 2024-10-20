// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputMouseState
    {
        public GameInputMouseButtons buttons;
        public long positionX;
        public long positionY;
        public long wheelX;
        public long wheelY;
    }
}
