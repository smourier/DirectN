// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KS_DVDCOPY_TITLEKEY
    {
        public uint KeyFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public uint[] ReservedNT;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] 
        public byte[] TitleKey;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] Reserved;
    }
}
