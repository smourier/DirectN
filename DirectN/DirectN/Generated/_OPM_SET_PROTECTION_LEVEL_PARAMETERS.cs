// generated from <Windows SDK Path>\um\opmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _OPM_SET_PROTECTION_LEVEL_PARAMETERS
    {
        public uint ulProtectionType;
        public uint ulProtectionLevel;
        public uint Reserved;
        public uint Reserved2;
    }
}
