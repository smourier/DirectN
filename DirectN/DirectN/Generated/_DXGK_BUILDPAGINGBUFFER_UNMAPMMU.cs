// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_UNMAPMMU
    {
        public IntPtr hAllocation;
        public ulong VirtualAddress;
        public ushort MmuId;
        public ushort Reserved0;
        public uint AllocationOffset;
        public uint NumberOfPages;
    }
}
