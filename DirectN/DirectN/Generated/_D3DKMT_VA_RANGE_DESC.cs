// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
