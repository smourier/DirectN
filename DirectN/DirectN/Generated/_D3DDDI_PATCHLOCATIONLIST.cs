// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(409,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_PATCHLOCATIONLIST
    {
        public uint AllocationIndex;
        public _D3DDDI_PATCHLOCATIONLIST__union_0 __union_1;
        public uint DriverId;
        public uint AllocationOffset;
        public uint PatchOffset;
        public uint SplitOffset;
    }
}
