// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
