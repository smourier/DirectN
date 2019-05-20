// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(7140,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct KSDISPLAYCHANGE
    {
        public uint PelsWidth;
        public uint PelsHeight;
        public uint BitsPerPel;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] 
        public string DeviceID;
    }
}
