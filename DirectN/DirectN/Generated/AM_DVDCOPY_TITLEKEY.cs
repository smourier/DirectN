// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dvdmedia.h(184,9)
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
