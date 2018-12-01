// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(2173,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETFORMATCOUNTDATA
    {
        public _DD_GETDRIVERINFO2DATA gdi2;
        public uint dwFormatCount;
        public uint dwReserved;
    }
}
