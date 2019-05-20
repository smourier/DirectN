// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(4204,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_VIDEO_GETCAPS_0020
    {
        public D3D12DDICAPS_TYPE_VIDEO_0020 Type;
        public IntPtr pInfo;
        public IntPtr pData;
        public uint DataSize;
    }
}
