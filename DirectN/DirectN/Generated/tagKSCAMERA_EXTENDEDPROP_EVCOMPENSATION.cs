// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(6210,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_EXTENDEDPROP_EVCOMPENSATION
    {
        public uint Mode;
        public int Min;
        public int Max;
        public int Value;
        public ulong Reserved;
    }
}
