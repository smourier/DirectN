// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(7575,9)
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
