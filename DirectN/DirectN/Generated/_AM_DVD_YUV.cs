// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dvdmedia.h(92,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _AM_DVD_YUV
    {
        public byte Reserved;
        public byte Y;
        public byte U;
        public byte V;
    }
}
