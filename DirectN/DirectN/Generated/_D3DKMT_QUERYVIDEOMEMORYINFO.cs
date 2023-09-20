// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYVIDEOMEMORYINFO
    {
        public IntPtr hProcess;
        public uint hAdapter;
        public _D3DKMT_MEMORY_SEGMENT_GROUP MemorySegmentGroup;
        public ulong Budget;
        public ulong CurrentUsage;
        public ulong CurrentReservation;
        public ulong AvailableForReservation;
        public uint PhysicalAdapterIndex;
    }
}
