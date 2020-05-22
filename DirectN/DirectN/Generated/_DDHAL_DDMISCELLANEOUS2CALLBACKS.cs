// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(848,9)
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
