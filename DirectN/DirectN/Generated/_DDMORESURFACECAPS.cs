// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(1086,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDMORESURFACECAPS
    {
        public uint dwSize;
        public _DDSCAPSEX ddsCapsMore;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagExtendedHeapRestrictions[] ddsExtendedHeapRestrictions;
    }
}
