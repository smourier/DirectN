// generated from <Windows SDK Path>\um\dmusicc.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DMUS_BUFFERDESC
    {
        public uint dwSize;
        public uint dwFlags;
        public Guid guidBufferFormat;
        public uint cbBuffer;
    }
}
