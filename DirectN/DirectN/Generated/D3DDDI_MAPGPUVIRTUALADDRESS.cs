// generated from <Windows SDK Path>\shared\d3dukmdt.h
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
