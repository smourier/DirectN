// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ks.h(2009,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSSTREAMALLOCATOR_STATUS
    {
        public KSALLOCATOR_FRAMING Framing;
        public uint AllocatedFrames;
        public uint Reserved;
    }
}
