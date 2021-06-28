// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(409,9)
using System;
using System.Runtime.InteropServices;
using PDD_ALPHABLT = System.IntPtr;
using PDD_CREATESURFACEEX = System.IntPtr;
using PDD_DESTROYDDLOCAL = System.IntPtr;
using PDD_GETDRIVERSTATE = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_MISCELLANEOUS2CALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr AlphaBlt;
        public IntPtr CreateSurfaceEx;
        public IntPtr GetDriverState;
        public IntPtr DestroyDDLocal;
    }
}
