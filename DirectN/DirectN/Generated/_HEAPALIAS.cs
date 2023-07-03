// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\ddrawi.h(624,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _HEAPALIAS
    {
        public ulong fpVidMem;
        public IntPtr lpAlias;
        public uint dwAliasSize;
    }
}
