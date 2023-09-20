// generated from <Windows SDK Path>\um\dvp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDVIDEOPORTCONNECT
    {
        public uint dwSize;
        public uint dwPortWidth;
        public Guid guidTypeID;
        public uint dwFlags;
        public IntPtr dwReserved1;
    }
}
