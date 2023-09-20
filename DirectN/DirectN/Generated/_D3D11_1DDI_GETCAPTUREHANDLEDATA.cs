// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D11_1DDI_GETCAPTUREHANDLEDATA
    {
        public D3D10DDI_HRESOURCE hResource;
        public uint ArrayIndex;
        public uint hAllocation;
        public uint DataOffset;
        public uint DataSize;
    }
}
