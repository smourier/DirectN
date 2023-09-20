// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSQUALITY
    {
        public IntPtr Context;
        public uint Proportion;
        public long DeltaTime;
    }
}
