// generated from <Windows SDK Path>\um\ddkmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDOPENVIDEOPORTIN
    {
        public IntPtr hDirectDraw;
        public uint dwVideoPortHandle;
        public IntPtr pfnVideoPortClose;
        public IntPtr pContext;
    }
}
