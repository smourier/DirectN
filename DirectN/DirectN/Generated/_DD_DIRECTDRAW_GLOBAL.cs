// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using LPDDVIDEOPORTCAPS = DirectN._DDVIDEOPORTCAPS;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_DIRECTDRAW_GLOBAL
    {
        public IntPtr dhpdev;
        public IntPtr dwReserved1;
        public IntPtr dwReserved2;
        public IntPtr lpDDVideoPortCaps;
    }
}
