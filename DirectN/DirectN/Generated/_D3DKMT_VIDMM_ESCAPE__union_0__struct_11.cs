// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_VIDMM_ESCAPE__union_0__struct_11
    {
        public uint hPagingQueue;
        public uint PhysicalAdapterIndex;
        public uint Milliseconds;
        public ulong PagingFenceValue;
    }
}
