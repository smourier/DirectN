// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRTAUDIO_HWREGISTER
    {
        public IntPtr Register;
        public uint Width;
        public ulong Numerator;
        public ulong Denominator;
        public uint Accuracy;
    }
}
