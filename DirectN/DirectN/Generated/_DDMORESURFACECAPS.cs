// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(1086,9)
using System;
using System.Runtime.InteropServices;
using DDSCAPSEX = DirectN._DDSCAPSEX;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDMORESURFACECAPS
    {
        public uint dwSize;
        public DDSCAPSEX ddsCapsMore;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagExtendedHeapRestrictions[][] ddsExtendedHeapRestrictions;
    }
}
