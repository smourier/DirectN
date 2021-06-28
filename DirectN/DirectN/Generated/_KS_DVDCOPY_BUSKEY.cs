// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(3635,9)
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
