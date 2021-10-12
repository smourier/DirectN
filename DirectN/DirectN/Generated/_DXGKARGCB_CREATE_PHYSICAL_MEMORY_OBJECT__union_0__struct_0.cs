// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(9415,9)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_0
    {
        public PHYSICAL_ADDRESS LowAddress;
        public PHYSICAL_ADDRESS HighAddress;
        public PHYSICAL_ADDRESS SkipBytes;
        public uint Flags;
    }
}
