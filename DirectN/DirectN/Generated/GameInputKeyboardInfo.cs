// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputKeyboardInfo
    {
        public GameInputKeyboardKind kind;
        public uint layout;
        public uint keyCount;
        public uint functionKeyCount;
        public uint maxSimultaneousKeys;
        public uint platformType;
        public uint platformSubtype;
        public IntPtr nativeLanguage;
    }
}
