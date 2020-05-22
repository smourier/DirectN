// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dvp.h(249,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDVIDEOPORTCONNECT
    {
        public uint dwSize;
        public uint dwPortWidth;
        public Guid guidTypeID;
        public uint dwFlags;
        public IntPtr dwReserved1;
    }
}
