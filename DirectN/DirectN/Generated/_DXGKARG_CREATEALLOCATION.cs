// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(3154,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATEALLOCATION
    {
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public uint NumAllocations;
        public IntPtr pAllocationInfo;
        public IntPtr hResource;
        public _DXGK_CREATEALLOCATIONFLAGS Flags;
    }
}
