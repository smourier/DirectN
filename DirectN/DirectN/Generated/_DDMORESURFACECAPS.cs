// generated from <Windows SDK Path>\um\ddrawi.h
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
