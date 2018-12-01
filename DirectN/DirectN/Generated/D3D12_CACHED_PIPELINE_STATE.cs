// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(1809,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_CACHED_PIPELINE_STATE
    {
        public IntPtr pCachedBlob;
        public ulong CachedBlobSizeInBytes;
    }
}
