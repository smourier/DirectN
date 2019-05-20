// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(6116,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_EXTENDEDPROP_HEADER
    {
        public uint Version;
        public uint PinId;
        public uint Size;
        public uint Result;
        public ulong Flags;
        public ulong Capability;
    }
}
