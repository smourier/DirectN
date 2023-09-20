// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_FILLVIRTUAL
    {
        public IntPtr hAllocation;
        public ulong AllocationOffsetInBytes;
        public ulong FillSizeInBytes;
        public uint FillPattern;
        public ulong DestinationVirtualAddress;
    }
}
