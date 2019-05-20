// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(3873,9)
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
