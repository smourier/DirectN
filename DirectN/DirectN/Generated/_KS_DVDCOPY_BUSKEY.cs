// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KS_DVDCOPY_BUSKEY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public byte[] BusKey;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] Reserved;
    }
}
