// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(3432,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_ALLOCATE
    {
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public IntPtr hResource;
        public uint hKMResource;
        public uint NumAllocations;
        public _D3DDDICB_ALLOCATE__union_0 __union_5;
    }
}
