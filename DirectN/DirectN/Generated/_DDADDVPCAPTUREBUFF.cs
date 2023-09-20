// generated from <Windows SDK Path>\um\ddkmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDADDVPCAPTUREBUFF
    {
        public IntPtr hCapture;
        public uint dwFlags;
        public int pMDL;
        public int pKEvent;
        public IntPtr lpBuffInfo;
    }
}
