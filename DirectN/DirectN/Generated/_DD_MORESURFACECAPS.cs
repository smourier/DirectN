// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_MORESURFACECAPS
    {
        public uint dwSize;
        public _DDSCAPSEX ddsCapsMore;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagNTExtendedHeapRestrictions[] ddsExtendedHeapRestrictions;
    }
}
