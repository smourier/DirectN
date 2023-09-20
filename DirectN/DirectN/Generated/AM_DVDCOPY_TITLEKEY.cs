// generated from <Windows SDK Path>\um\dvdmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AM_DVDCOPY_TITLEKEY
    {
        public uint KeyFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public uint[] Reserved1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] 
        public byte[] TitleKey;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] Reserved2;
    }
}
