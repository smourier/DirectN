// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DSEFFECTDESC
    {
        public uint dwSize;
        public uint dwFlags;
        public Guid guidDSFXClass;
        public IntPtr dwReserved1;
        public IntPtr dwReserved2;
    }
}
