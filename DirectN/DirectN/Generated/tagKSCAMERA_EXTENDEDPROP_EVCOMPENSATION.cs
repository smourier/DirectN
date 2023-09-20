// generated from <Windows SDK Path>\shared\ksmedia.h
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
