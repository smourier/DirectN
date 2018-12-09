// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(1227,9)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWCLIPPER_GBL
    {
        public uint dwRefCnt;
        public uint dwFlags;
        public IntPtr lpDD;
        public uint dwProcessId;
        public IntPtr dwReserved1;
        public IntPtr hWnd;
        public IntPtr lpStaticClipList;
    }
}
