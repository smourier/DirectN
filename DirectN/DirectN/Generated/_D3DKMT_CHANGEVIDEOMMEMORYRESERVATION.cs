// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CHANGEVIDEOMMEMORYRESERVATION
    {
        public IntPtr hProcess;
        public uint hAdapter;
        public _D3DKMT_MEMORY_SEGMENT_GROUP MemorySegmentGroup;
        public ulong Reservation;
        public uint PhysicalAdapterIndex;
    }
}
