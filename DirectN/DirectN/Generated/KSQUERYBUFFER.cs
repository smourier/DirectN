// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ks.h(431,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSQUERYBUFFER
    {
        public KSIDENTIFIER Event;
        public IntPtr EventData;
        public IntPtr Reserved;
    }
}
