// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ks.h(437,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRELATIVEEVENT
    {
        public uint Size;
        public uint Flags;
        public __struct_ks_288__union_0 __union_2;
        public IntPtr Reserved;
        public KSIDENTIFIER Event;
        public KSEVENTDATA EventData;
    }
}
