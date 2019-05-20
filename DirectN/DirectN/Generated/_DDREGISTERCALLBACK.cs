// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddkmapi.h(357,13)
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
