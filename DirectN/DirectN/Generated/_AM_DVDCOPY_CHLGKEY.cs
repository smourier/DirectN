// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dvdmedia.h(170,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _AM_DVDCOPY_CHLGKEY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)] 
        public byte[] ChlgKey;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] Reserved;
    }
}
