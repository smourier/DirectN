// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\shtypes.h(304,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _SHELLDETAILS
    {
        public int fmt;
        public int cxChar;
        public _STRRET str;
    }
}
