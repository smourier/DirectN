// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dukmdt.h(1434,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_UPDATEGPUVIRTUALADDRESS_OPERATION__union_0__struct_1
    {
        public ulong BaseAddress;
        public ulong SizeInBytes;
        public uint hAllocation;
        public ulong AllocationOffsetInBytes;
        public ulong AllocationSizeInBytes;
        public _D3DDDIGPUVIRTUALADDRESS_PROTECTION_TYPE Protection;
        public ulong DriverProtection;
    }
}
