// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ks.h(2304,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRATE
    {
        public long PresentationStart;
        public long Duration;
        public KSIDENTIFIER Interface;
        public int Rate;
        public uint Flags;
    }
}
