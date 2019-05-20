// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(3630,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KS_DVDCOPY_CHLGKEY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)] 
        public byte[] ChlgKey;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] Reserved;
    }
}
