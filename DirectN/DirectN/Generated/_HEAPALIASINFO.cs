// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(632,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _HEAPALIASINFO
    {
        public uint dwRefCnt;
        public uint dwFlags;
        public uint dwNumHeaps;
        public IntPtr lpAliases;
    }
}
