// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(2179,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_SUBRESOURCE_DATA
    {
        public IntPtr pSysMem;
        public uint SysMemPitch;
        public uint SysMemSlicePitch;
    }
}
