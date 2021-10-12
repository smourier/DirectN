// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4275,9)
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
