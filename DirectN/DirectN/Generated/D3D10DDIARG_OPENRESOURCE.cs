// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDIARG_OPENRESOURCE
    {
        public uint NumAllocations;
        public D3D10DDIARG_OPENRESOURCE__union_0 __union_1;
        public D3D10DDI_HKMRESOURCE hKMResource;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}
