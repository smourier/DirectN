// generated from <Windows SDK Path>\um\dvdmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _AM_DVDCOPY_BUSKEY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public byte[] BusKey;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] Reserved;
    }
}
