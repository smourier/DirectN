// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_MEMORY
    {
        public ulong TotalBytesEvicted;
        public uint AllocsCommitted;
        public uint AllocsResident;
    }
}
