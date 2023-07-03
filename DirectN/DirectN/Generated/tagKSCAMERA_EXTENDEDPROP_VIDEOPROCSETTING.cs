// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(6245,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_EXTENDEDPROP_VIDEOPROCSETTING
    {
        public uint Mode;
        public int Min;
        public int Max;
        public int Step;
        public tagKSCAMERA_EXTENDEDPROP_VALUE VideoProc;
        public ulong Reserved;
    }
}
