// generated from <Windows SDK Path>\um\wincodec.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICBitmapPattern
    {
        public ulong Position;
        public uint Length;
        public IntPtr Pattern;
        public IntPtr Mask;
        public bool EndOfStream;
    }
}
