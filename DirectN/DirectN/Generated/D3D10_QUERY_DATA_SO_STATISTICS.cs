// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\d3d10.h(4810,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_QUERY_DATA_SO_STATISTICS
    {
        public ulong NumPrimitivesWritten;
        public ulong PrimitivesStorageNeeded;
    }
}
