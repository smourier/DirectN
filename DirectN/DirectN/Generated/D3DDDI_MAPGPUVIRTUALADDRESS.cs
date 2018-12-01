// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1423,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDI_MAPGPUVIRTUALADDRESS
    {
        public uint hPagingQueue;
        public ulong BaseAddress;
        public ulong MinimumAddress;
        public ulong MaximumAddress;
        public uint hAllocation;
        public ulong OffsetInPages;
        public ulong SizeInPages;
        public _D3DDDIGPUVIRTUALADDRESS_PROTECTION_TYPE Protection;
        public ulong DriverProtection;
        public uint Reserved0;
        public ulong Reserved1;
        public ulong VirtualAddress;
        public ulong PagingFenceValue;
    }
}
