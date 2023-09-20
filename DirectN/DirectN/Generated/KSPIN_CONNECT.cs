// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPIN_CONNECT
    {
        public KSIDENTIFIER Interface;
        public KSIDENTIFIER Medium;
        public uint PinId;
        public IntPtr PinToHandle;
        public KSPRIORITY Priority;
    }
}
