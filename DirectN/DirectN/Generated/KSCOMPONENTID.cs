// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ks.h(481,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSCOMPONENTID
    {
        public Guid Manufacturer;
        public Guid Product;
        public Guid Component;
        public Guid Name;
        public uint Version;
        public uint Revision;
    }
}
