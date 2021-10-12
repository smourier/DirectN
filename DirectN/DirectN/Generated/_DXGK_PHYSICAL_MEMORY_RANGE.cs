// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(2144,9)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PHYSICAL_MEMORY_RANGE
    {
        public PHYSICAL_ADDRESS BaseAddress;
        public long NumberOfBytes;
    }
}
