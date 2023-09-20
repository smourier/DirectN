// generated from <Windows SDK Path>\shared\ksmedia.h
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
