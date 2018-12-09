// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ks.h(2003,9)
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
