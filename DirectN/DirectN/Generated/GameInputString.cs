// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputString
    {
        public uint sizeInBytes;
        public uint codePointCount;
        [MarshalAs(UnmanagedType.LPStr)] 
        public byte data;
    }
}
