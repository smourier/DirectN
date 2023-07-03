// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\mmsyscom.h(118,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct mmtime_tag__union_0__struct_0
    {
        public byte hour;
        public byte min;
        public byte sec;
        public byte frame;
        public byte fps;
        public byte dummy;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] pad;
    }
}
