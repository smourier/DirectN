// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(458,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_DDIARG_SUBRESOURCE_UP
    {
        public IntPtr pSysMem;
        public uint SysMemPitch;
        public uint SysMemSlicePitch;
    }
}
