// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_TRANSFERVIRTUAL
    {
        public IntPtr hAllocation;
        public ulong AllocationOffsetInBytes;
        public ulong TransferSizeInBytes;
        public ulong SourceVirtualAddress;
        public ulong DestinationVirtualAddress;
        public ulong SourcePageTable;
        public _DXGK_MEMORY_TRANSFER_DIRECTION TransferDirection;
        public _DXGK_TRANSFERVIRTUALFLAGS Flags;
        public ulong DestinationPageTable;
    }
}
