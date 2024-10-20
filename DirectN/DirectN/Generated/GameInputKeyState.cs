// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputKeyState
    {
        public uint scanCode;
        public uint codePoint;
        public byte virtualKey;
        public bool isDeadKey;
    }
}
