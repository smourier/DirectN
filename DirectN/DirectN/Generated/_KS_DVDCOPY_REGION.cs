// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(3665,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KS_DVDCOPY_REGION
    {
        public byte Reserved;
        public byte RegionData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] Reserved2;
    }
}
