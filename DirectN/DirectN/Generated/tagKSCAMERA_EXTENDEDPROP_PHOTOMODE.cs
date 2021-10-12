// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(6194,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_EXTENDEDPROP_PHOTOMODE
    {
        public uint RequestedHistoryFrames;
        public uint MaxHistoryFrames;
        public uint SubMode;
        public uint Reserved;
    }
}
