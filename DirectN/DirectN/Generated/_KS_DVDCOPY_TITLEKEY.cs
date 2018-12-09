// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(3606,9)
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
