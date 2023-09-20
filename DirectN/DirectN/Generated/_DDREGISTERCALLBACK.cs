// generated from <Windows SDK Path>\um\ddkmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDREGISTERCALLBACK
    {
        public IntPtr hDirectDraw;
        public uint dwEvents;
        public IntPtr pfnCallback;
        public IntPtr dwParam1;
        public IntPtr dwParam2;
        public IntPtr pContext;
    }
}
