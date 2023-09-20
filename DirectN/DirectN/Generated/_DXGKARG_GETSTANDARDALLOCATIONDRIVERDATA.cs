// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_GETSTANDARDALLOCATIONDRIVERDATA
    {
        public _D3DKMDT_STANDARDALLOCATION_TYPE StandardAllocationType;
        public _DXGKARG_GETSTANDARDALLOCATIONDRIVERDATA__union_0 __union_1;
        public IntPtr pAllocationPrivateDriverData;
        public uint AllocationPrivateDriverDataSize;
        public IntPtr pResourcePrivateDriverData;
        public uint ResourcePrivateDriverDataSize;
        public uint PhysicalAdapterIndex;
    }
}
