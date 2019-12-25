// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ks.h(1751,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KS_FRAMING_ITEM
    {
        public Guid MemoryType;
        public Guid BusType;
        public uint MemoryFlags;
        public uint BusFlags;
        public uint Flags;
        public uint Frames;
        public __struct_ks_419__union_0 __union_6;
        public uint MemoryTypeWeight;
        public KS_FRAMING_RANGE PhysicalRange;
        public KS_FRAMING_RANGE_WEIGHTED FramingRange;
    }
}
