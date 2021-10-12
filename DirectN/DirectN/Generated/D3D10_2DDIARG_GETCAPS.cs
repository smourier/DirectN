// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(7239,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_2DDIARG_GETCAPS
    {
        public D3D10_2DDICAPS_TYPE Type;
        public IntPtr pInfo;
        public IntPtr pData;
        public uint DataSize;
    }
}
