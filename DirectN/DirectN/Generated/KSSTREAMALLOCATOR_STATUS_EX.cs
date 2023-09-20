// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSSTREAMALLOCATOR_STATUS_EX
    {
        public KSALLOCATOR_FRAMING_EX Framing;
        public uint AllocatedFrames;
        public uint Reserved;
    }
}
