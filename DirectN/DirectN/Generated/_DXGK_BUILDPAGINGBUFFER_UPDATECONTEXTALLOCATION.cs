// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_UPDATECONTEXTALLOCATION
    {
        public ulong ContextAllocation;
        public ulong ContextAllocationSize;
        public IntPtr pDriverPrivateData;
        public uint DriverPrivateDataSize;
    }
}
