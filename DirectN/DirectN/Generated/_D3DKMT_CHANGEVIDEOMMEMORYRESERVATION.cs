// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(4066,9)
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
