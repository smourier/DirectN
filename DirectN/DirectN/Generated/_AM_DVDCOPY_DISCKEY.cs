// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dvdmedia.h(180,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _AM_DVDCOPY_DISCKEY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2048)] 
        public byte[] DiscKey;
    }
}
