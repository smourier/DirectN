// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(5066,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct REGFILTER2
    {
        public uint dwVersion;
        public uint dwMerit;
        public REGFILTER2__union_0 __union_2;
    }
}
