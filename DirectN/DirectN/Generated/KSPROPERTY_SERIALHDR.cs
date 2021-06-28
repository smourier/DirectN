// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ks.h(3086,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_SERIALHDR
    {
        public Guid PropertySet;
        public uint Count;
    }
}
