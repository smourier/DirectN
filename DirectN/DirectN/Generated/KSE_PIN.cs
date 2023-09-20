// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSE_PIN
    {
        public KSIDENTIFIER Event;
        public uint PinId;
        public uint Reserved;
    }
}
