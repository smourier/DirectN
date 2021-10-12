// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mmsyscom.h(107,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct mmtime_tag
    {
        public uint wType;
        public mmtime_tag__union_0 u;
    }
}
