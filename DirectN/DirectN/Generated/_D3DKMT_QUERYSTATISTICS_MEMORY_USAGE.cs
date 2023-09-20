// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
