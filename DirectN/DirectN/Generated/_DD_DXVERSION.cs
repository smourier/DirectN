// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dhal.h(2198,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_DXVERSION
    {
        public _DD_GETDRIVERINFO2DATA gdi2;
        public uint dwDXVersion;
        public uint dwReserved;
    }
}
