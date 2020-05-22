// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(1265,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _ATTACHLIST
    {
        public uint dwFlags;
        public IntPtr lpLink;
        public IntPtr lpAttached;
        public IntPtr lpIAttached;
    }
}
