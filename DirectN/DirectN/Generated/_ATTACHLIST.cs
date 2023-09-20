// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _ATTACHLIST
    {
        public uint dwFlags;
        public IntPtr lpLink;
        public IntPtr lpAttached;
        public IntPtr lpIAttached;
    }
}
