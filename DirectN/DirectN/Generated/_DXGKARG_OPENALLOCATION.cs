// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(982,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_OPENALLOCATION
    {
        public uint NumAllocations;
        public IntPtr pOpenAllocation;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverSize;
        public _DXGK_OPENALLOCATIONFLAGS Flags;
        public uint SubresourceIndex;
        public IntPtr SubresourceOffset;
        public uint Pitch;
    }
}
