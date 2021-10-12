// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(488,9)
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
