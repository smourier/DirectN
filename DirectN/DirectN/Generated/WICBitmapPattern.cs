// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(662,24)
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
