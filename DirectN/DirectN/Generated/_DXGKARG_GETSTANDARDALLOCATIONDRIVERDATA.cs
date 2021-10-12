// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(3706,9)
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
