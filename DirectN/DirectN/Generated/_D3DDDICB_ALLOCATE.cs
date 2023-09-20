// generated from <Windows SDK Path>\um\d3dumddi.h
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
