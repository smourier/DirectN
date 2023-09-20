// generated from <Windows SDK Path>\um\ddkmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDGETAUTOFLIPOUT
    {
        public uint ddRVal;
        public IntPtr hVideoSurface;
        public IntPtr hVBISurface;
        public bool bPolarity;
    }
}
