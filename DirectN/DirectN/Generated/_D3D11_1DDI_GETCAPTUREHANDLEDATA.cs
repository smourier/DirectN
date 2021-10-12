// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(3766,9)
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
