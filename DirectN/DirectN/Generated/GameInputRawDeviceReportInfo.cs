// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputRawDeviceReportInfo
    {
        public GameInputRawDeviceReportKind kind;
        public uint id;
        public uint size;
        public uint itemCount;
        public IntPtr items;
    }
}
