// generated from <Windows SDK Path>\shared\ksmedia.h
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
