// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(2397,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_VA_RANGE_DESC
    {
        public ulong VadAddress;
        public uint VaRangeIndex;
        public uint PhysicalAdapterIndex;
        public ulong StartAddress;
        public ulong EndAddress;
        public ulong DriverProtection;
        public uint OwnerType;
        public ulong pOwner;
        public ulong OwnerOffset;
        public uint Protection;
    }
}
