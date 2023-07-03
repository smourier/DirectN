// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(1515,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRTAUDIO_HWREGISTER32
    {
        public uint Register;
        public uint Width;
        public ulong Numerator;
        public ulong Denominator;
        public uint Accuracy;
    }
}
