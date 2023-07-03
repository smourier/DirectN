// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3891,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_MEMORY_USAGE
    {
        public ulong AllocatedBytes;
        public ulong FreeBytes;
        public ulong ZeroBytes;
        public ulong ModifiedBytes;
        public ulong StandbyBytes;
    }
}
