// generated from <Windows SDK Path>\um\d3d12umddi.h
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
