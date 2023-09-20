// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHAL_CREATESURFACEEX = System.IntPtr;
using LPDDHAL_DESTROYDDLOCAL = System.IntPtr;
using LPDDHAL_GETDRIVERSTATE = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DDMISCELLANEOUS2CALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr Reserved;
        public IntPtr CreateSurfaceEx;
        public IntPtr GetDriverState;
        public IntPtr DestroyDDLocal;
    }
}
