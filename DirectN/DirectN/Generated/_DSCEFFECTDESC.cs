// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DSCEFFECTDESC
    {
        public uint dwSize;
        public uint dwFlags;
        public Guid guidDSCFXClass;
        public Guid guidDSCFXInstance;
        public uint dwReserved1;
        public uint dwReserved2;
    }
}
