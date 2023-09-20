// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_MAPCONTEXTALLOCATION
    {
        public ulong BaseAddress;
        public ulong MinimumAddress;
        public ulong MaximumAddress;
        public IntPtr hAllocation;
        public ulong OffsetInPages;
        public ulong SizeInPages;
        public _D3DDDIGPUVIRTUALADDRESS_PROTECTION_TYPE Protection;
        public ulong DriverProtection;
    }
}
