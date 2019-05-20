// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawint.h(967,9)
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
