// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(2681,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_TEXTURE_COPY_LOCATION
    {
        public IntPtr pResource;
        public D3D12_TEXTURE_COPY_TYPE Type;
        public D3D12_TEXTURE_COPY_LOCATION__union_0 __union_2;
    }
}
