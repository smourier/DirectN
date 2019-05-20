// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(2494,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_GETCAPS
    {
        public D3D12DDICAPS_TYPE Type;
        public IntPtr pInfo;
        public IntPtr pData;
        public uint DataSize;
    }
}
