// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(3813,9)
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
