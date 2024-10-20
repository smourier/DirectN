// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_NOTIFYALLOC
    {
        public IntPtr hAllocation;
        public IntPtr hKmdProcessHandle;
        public _DXGK_NOTIFYALLOCFLAGS Flags;
        public ulong OffsetInBytes;
        public ulong SizeInBytes;
        public ulong GpuVirtualAddressAtOffset;
    }
}
