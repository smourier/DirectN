// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SEGMENTDESCRIPTOR2
    {
        public _DXGK_SEGMENTFLAGS2 Flags;
        public IntPtr Size;
        public int pMdl;
        public PHYSICAL_ADDRESS BaseAddress;
        public PHYSICAL_ADDRESS CpuTranslatedAddress;
    }
}
