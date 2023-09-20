// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRELATIVEEVENT
    {
        public uint Size;
        public uint Flags;
        public __struct_ks_178__union_0 __union_2;
        public IntPtr Reserved;
        public KSIDENTIFIER Event;
        public KSEVENTDATA EventData;
    }
}
