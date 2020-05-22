// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dvp.h(389,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDVIDEOPORTSTATUS
    {
        public uint dwSize;
        public bool bInUse;
        public uint dwFlags;
        public uint dwReserved1;
        public _DDVIDEOPORTCONNECT VideoPortType;
        public IntPtr dwReserved2;
        public IntPtr dwReserved3;
    }
}
